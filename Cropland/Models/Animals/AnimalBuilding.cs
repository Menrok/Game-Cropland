namespace Cropland.Models.Animals;

public class AnimalBuilding
{
    public string AnimalType { get; set; } = string.Empty;
    public int Level { get; set; }
    public DateTime? LastCollected { get; set; }
}