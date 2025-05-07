using Cropland.Models.Farm;

namespace Cropland.Models.Fields;

public class Field
{
    public int Id { get; set; }
    public Position Position { get; set; } = new();
    public CropType? Crop { get; set; }
    public DateTime? PlantedAt { get; set; }
    public bool IsWatered { get; set; }
}