using System;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ItemIn item;
    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        InventoryManager.Instance.AddItem(item);
        Destroy(gameObject);
    }

    private void OnMouseDown() {
        PickUp();
    }
}
