namespace Cropland.Models.Production;

public class ProductionBuilding
{
    public string Name { get; set; }
    public string ProducingItem { get; set; }
    public DateTime? StartedAt { get; set; }
    public int Level { get; set; }
}
