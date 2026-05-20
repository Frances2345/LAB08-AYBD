using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<LootByQuality> lootDictionary;

    private InputSystem_Actions inputActions;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI idText;
    public TextMeshProUGUI descriptionText;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        inputActions.Player.GiveCard.performed += ctx => OnGiveCard();
    }

    private void OnEnable() { inputActions.Enable(); }

    private void OnDisable() { inputActions.Disable(); }

    public void OnGiveCard()
    {
        ItemData obtainedItem = GetRandomItem(ItemQuality.Common);

        if (obtainedItem != null)
        {
            nameText.text = "Name: " + obtainedItem.Name;
            idText.text = "ID: " + obtainedItem.ID.ToString();
            descriptionText.text = obtainedItem.Description;

            Debug.Log("Generated Item: " + obtainedItem.Name + " | ID: " + obtainedItem.ID);
        }
        else
        {
            Debug.Log("No items found.");
        }
    }

    public void OnGiveCardRare()
    {
        ItemData obtainedItem = GetRandomItem(ItemQuality.Rare);

        if (obtainedItem != null)
        {
            nameText.text = "Name: " + obtainedItem.Name;
            idText.text = "ID: " + obtainedItem.ID.ToString();
            descriptionText.text = obtainedItem.Description;

            Debug.Log("Generated Item: " + obtainedItem.Name + " | ID: " + obtainedItem.ID);
        }
        else
        {
            Debug.Log("No items found.");
        }
    }

    public void OnGiveCardEpic()
    {
        ItemData obtainedItem = GetRandomItem(ItemQuality.Epic);

        if (obtainedItem != null)
        {
            nameText.text = "Name: " + obtainedItem.Name;
            idText.text = "ID: " + obtainedItem.ID.ToString();
            descriptionText.text = obtainedItem.Description;

            Debug.Log("Generated Item: " + obtainedItem.Name + " | ID: " + obtainedItem.ID);
        }
        else
        {
            Debug.Log("No items found.");
        }
    }

    public void OnGiveCardLegendary()
    {
        ItemData obtainedItem = GetRandomItem(ItemQuality.Legendary);

        if (obtainedItem != null)
        {
            nameText.text = "Name: " + obtainedItem.Name;
            idText.text = "ID: " + obtainedItem.ID.ToString();
            descriptionText.text = obtainedItem.Description;

            Debug.Log("Generated Item: " + obtainedItem.Name + " | ID: " + obtainedItem.ID);
        }
        else
        {
            Debug.Log("No items found.");
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