namespace Cropland.Models.Animals;

public static class AnimalList
{
    public static readonly List<AnimalType> All = new()
    {
        new AnimalType { Name = "Kura", Product = "Jajko", ProductionIntervalSeconds = 1800 },
        new AnimalType { Name = "Krowa", Product = "Mleko", ProductionIntervalSeconds = 3600 }
    };

    public static AnimalType? GetByName(string name)
        => All.FirstOrDefault(a => a.Name == name);
}