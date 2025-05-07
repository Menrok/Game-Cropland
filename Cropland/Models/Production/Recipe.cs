namespace Cropland.Models.Production;

public class Recipe
{
    public string ProductName { get; set; }
    public Dictionary<string, int> Ingredients { get; set; } = new();
    public int ProductionTimeSeconds { get; set; }
}