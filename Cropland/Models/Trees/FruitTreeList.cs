namespace Cropland.Models.Trees;

public static class FruitTreeList
{
    public static readonly List<FruitTreeType> All = new()
    {
        new FruitTreeType
        {
            Name = "Jabłoń",
            Product = "Jabłko",
            YieldIntervalSeconds = 21600,
            IconPath = "icons/apple_tree.png"
        }
    };

    public static FruitTreeType? GetByName(string name)
        => All.FirstOrDefault(t => t.Name == name);
}
