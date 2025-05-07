namespace Cropland.Models.Farm;

public class Storage
{
    public Dictionary<string, int> Ingredients { get; set; } = new();
    public Dictionary<string, int> Products { get; set; } = new();
}