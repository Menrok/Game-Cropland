using Cropland.Models.Animals;
using Cropland.Models.Fields;
using Cropland.Models.Production;
using Cropland.Models.Trees;

namespace Cropland.Models.Farm;

public class Player
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    public int Coins { get; set; }
    public DateTime LastSaveTime { get; set; }

    public List<Field> Fields { get; set; } = new();
    public List<FruitTreeInstance> FruitTrees { get; set; } = new();
    public List<AnimalBuilding> AnimalBuildings { get; set; } = new();
    public List<ProductionBuilding> Workshops { get; set; } = new();
    public Storage Storage { get; set; } = new();
    public WaterTank WaterTank { get; set; } = new();

}
