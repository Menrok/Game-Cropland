namespace Cropland.Services;

public class ModalService
{
    public bool IsFieldsOpen { get; private set; }
    public bool IsTreesOpen { get; private set; }
    public bool IsAnimalsOpen { get; private set; }
    public bool IsCraftingOpen { get; private set; }

    public event Action? OnModalChanged;

    public void OpenFields()
    {
        CloseAll();
        IsFieldsOpen = true;
        OnModalChanged?.Invoke();
    }

    public void OpenTrees()
    {
        CloseAll();
        IsTreesOpen = true;
        OnModalChanged?.Invoke();
    }

    public void OpenAnimals()
    {
        CloseAll();
        IsAnimalsOpen = true;
        OnModalChanged?.Invoke();
    }

    public void OpenCrafting()
    {
        CloseAll();
        IsCraftingOpen = true;
        OnModalChanged?.Invoke();
    }

    public void CloseAll()
    {
        IsFieldsOpen = false;
        IsTreesOpen = false;
        IsAnimalsOpen = false;
        IsCraftingOpen = false;
        OnModalChanged?.Invoke();
    }
}
