namespace Cropland.Models.Fields;

public class CropType
{
    public string Name { get; set; } = string.Empty;
    public int GrowthTimeSeconds { get; set; }
    public string Product { get; set; } = string.Empty;
    public string IconPath { get; set; } = string.Empty;
}