using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class ItemIn : ScriptableObject
{
    [SerializeField] private int id;
    [SerializeField] private string itemName;
    [SerializeField] private int value;
    [SerializeField] private Sprite image;
    [SerializeField] private ItemType itemType;

    public int Id => id;
    public string Name => itemName;
    public int Value => value;
    public Sprite Image => image;
    public ItemType ItemType => itemType;


}


public enum ItemType
{
    Consumable,
    Weapon,
}