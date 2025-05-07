namespace Cropland.Models.Fields;

public static class CropList
{
    public static readonly List<CropType> All = new()
    {
        new CropType
        {
            Name = "Pszenica",
            Product = "Pszenica",
            GrowthTimeSeconds = 300,
            IconPath = "icons/crops/wheat.png"
        },
        new CropType
        {
            Name = "Sałata",
            Product = "Sałata",
            GrowthTimeSeconds = 400,
            IconPath = "icons/crops/lettuce.png"
        },
        new CropType
        {
            Name = "Marchewka",
            Product = "Marchewka",
            GrowthTimeSeconds = 600,
            IconPath = "icons/crops/carrot.png"
        },
        new CropType
        {
            Name = "Kukurydza",
            Product = "Kukurydza",
            GrowthTimeSeconds = 800,
            IconPath = "icons/crops/corn.png"
        }
    };

    public static CropType? GetByName(string name)
        => All.FirstOrDefault(c => c.Name == name);
}
