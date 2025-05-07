using Blazored.LocalStorage;
using Cropland.Models.Farm;
using Cropland.Models.Fields;

namespace Cropland.Services;

public class GameStateService
{
    private readonly ILocalStorageService _localStorage;
    private const string SaveKey = "cropland-save";

    public Player Player { get; private set; } = new();

    public event Action? OnStateChanged;

    public GameStateService(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    public async Task LoadOrCreateGameAsync()
    {
        var loaded = await _localStorage.GetItemAsync<Player>(SaveKey);
        if (loaded is not null)
        {
            Player = loaded;
        }
        else
        {
            InitializeNewGame();
        }

        NotifyStateChanged();
    }

    public async Task SaveGameAsync()
    {
        Player.LastSaveTime = DateTime.Now;
        await _localStorage.SetItemAsync(SaveKey, Player);
    }

    public void InitializeNewGame()
    {
        Player = new Player
        {
            Name = "Gracz",
            Level = 1,
            Coins = 100,
            LastSaveTime = DateTime.Now,
            Storage = new Storage(),
            WaterTank = new WaterTank { Capacity = 20, CurrentAmount = 20 }
        };

        for (int i = 0; i < 4; i++)
        {
            Player.Fields.Add(new Field
            {
                Id = i,
                Position = new Position(i, 0)
            });
        }

        NotifyStateChanged();
    }

    public async Task PlantCropAsync(int fieldId, CropType crop)
    {
        var field = Player.Fields.FirstOrDefault(f => f.Id == fieldId);
        if (field is not null && field.Crop == null)
        {
            field.Crop = crop;
            field.PlantedAt = DateTime.Now;
            field.IsWatered = false;
            await SaveGameAsync();
            NotifyStateChanged();
        }
    }

    private void NotifyStateChanged() => OnStateChanged?.Invoke();
}