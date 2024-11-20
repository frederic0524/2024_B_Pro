public class RecipeList
{
    public static CraftingRecipe[] KitchenRecipes = new CraftingRecipe[]
    {
        new CraftingRecipe
        {
            itemName = "��ä ��Ʃ",
            resultItem = ItemType.VegetableStew,
            resultAmount = 1,
            hungerRestoreAmount = 40f,
            requiredItems = new ItemType[] {ItemType.Plant, ItemType.Bush },
            requiredAmounts = new int[] {3, 3 }
        },
    };

    public static CraftingRecipe[] WorkbenchRecipes = new CraftingRecipe[]
    {
        new CraftingRecipe
        {
            itemName = "���� Ű��",
            resultItem = ItemType.RepairKit,
            resultAmount = 1,
            requiredAmounts = 25f,
            requiredAmounts = new int[] {3 }
        },
    };
}