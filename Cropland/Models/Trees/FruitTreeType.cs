namespace Cropland.Models.Trees;

public class FruitTreeType
{
    public string Name { get; set; } = string.Empty;
    public int YieldIntervalSeconds { get; set; }
    public string Product { get; set; } = string.Empty;
    public string IconPath { get; set; } = string.Empty;
}
