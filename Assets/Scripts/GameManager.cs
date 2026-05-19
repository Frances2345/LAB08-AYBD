using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public List<LootByQuality> lootDictionary;

    public void OnGenerate()
    {
        ItemData obtainedItem = GetRandomItem(ItemQuality.Epic);

        if (obtainedItem != null)
        {
            Debug.Log("Generated Item: " + obtainedItem.Name + " | ID: " + obtainedItem.ID);
        }
        else
        {
            Debug.Log("No items found in this quality list.");
        }
    }

    public ItemData GetRandomItem(ItemQuality quality)
    {
        foreach (LootByQuality loot in lootDictionary)
        {
            if (loot.quality == quality)
            {
                if (loot.itemList.Count > 0)
                {
                    int randomIndex = Random.Range(0, loot.itemList.Count);
                    return loot.itemList[randomIndex];
                }
            }
        }
        return null;
    }
}