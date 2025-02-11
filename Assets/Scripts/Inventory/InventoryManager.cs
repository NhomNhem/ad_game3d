using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public List<ItemIn> items = new List<ItemIn>();

    public Transform itemsParent;
    public GameObject itemPrefab;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        Instance = this;
    }

    public void AddItem(ItemIn item)
    {
        items.Add(item);
        DisplayInventory();
    }

    public void DisplayInventory() {
        foreach (Transform item in itemsParent) {
            Destroy(item.gameObject);
        }

        foreach (ItemIn itemIn in items) {
            GameObject itemObject = Instantiate(itemPrefab, itemsParent);
            TextMeshProUGUI itemName = itemObject.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            Image itemImage = itemObject.transform.Find("ItemImage").GetComponent<Image>();

            itemName.text = itemIn.Name;
            itemImage.sprite = itemIn.Image;

        }
    }

}
