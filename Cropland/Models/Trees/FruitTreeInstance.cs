using Cropland.Models.Farm;

namespace Cropland.Models.Trees;

public class FruitTreeInstance
{
    public FruitTreeType Type { get; set; } = new FruitTreeType();
    public Position Position { get; set; } = new Position();
    public DateTime LastHarvestedAt { get; set; }
}