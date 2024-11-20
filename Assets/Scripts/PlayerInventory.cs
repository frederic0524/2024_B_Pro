using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int crystalCount = 0;
    public int plantCount = 0;
    public int bushCount = 0;
    public int treeCount = 0;
    // Start is called before the first frame update

    public void Start()
    {
        survivalStats = GetComponent<SurvivalStats>();
    }

    public void UseItem(ItemType itemType)
    {
        if (GetComponent(itemType) <= 0)
        {
            return;
        }

        switch (itemType)
        {
            case ItemType.VegetableStew;
                Removeitem(ItemType.VegetableStew, 1);
                SurvivalStats.EatFood(RecipeList.KitchenRecipes[0].hungerRestoreAmount);
                break;
        }
    }
    private void Removeitem(ItemType itemType, int amount =1)
    {
        switch (itemType)
        {
            case ItemType.Crystal:
                crystalCount++;
                Debug.Log($"크리스탈 획득! 현재 개수 :{crystalCount} ");
                break;
            case ItemType.Plant:
                crystalCount++;
                Debug.Log($"식물 획득! 현재 개수 :{plantCount} ");
                break;
            case ItemType.Bush:
                crystalCount++;
                Debug.Log($"수풀 획득! 현재 개수 :{bushCount} ");
                break;
            case ItemType.Tree:
                crystalCount++;
                Debug.Log($"나무 획득! 현재 개수 :{treeCount} ");
                break;
        }
    }

    //아이템을 제거하는 함수
    public bool Removeitem(ItemType itemType, int amount =1)
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ShowInventory();
        }

    }




    private void ShowInventory()
    {
        Debug.Log("====인벤토리====");
        Debug.Log($"크리스탈:{crystalCount}개");
        Debug.Log($"식물:{plantCount}개");
        Debug.Log($"수풀:{bushCount}개");
        Debug.Log($"나무:{treeCount}개");
        Debug.Log("=================");
    }
}