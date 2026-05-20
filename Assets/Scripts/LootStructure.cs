using System.Collections.Generic;
using UnityEngine;

public enum ItemQuality
{
    Common,
    Rare,
    Epic,
    Legendary
}

[System.Serializable]
public struct LootByQuality
{
    public ItemQuality quality;
    public List<ItemData> itemList;
}

public class LootStructure : MonoBehaviour
{

}