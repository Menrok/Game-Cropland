namespace Cropland.Models.Production;

public static class RecipeList
{
    public static readonly List<Recipe> All = new()
    {
        new Recipe
        {
            ProductName = "Chleb",
            Ingredients = new() { { "Mąka", 2 }, { "Jajko", 1 } },
            ProductionTimeSeconds = 180
        }
    };

    public static Recipe? GetByProduct(string name)
        => All.FirstOrDefault(r => r.ProductName == name);
}
