using UnityEngine;

namespace SF.Inventory
{
    public enum ItemSubType
    {
        Consumable,
        Key,
        Equipment,
        None // This is used for when filtering items in different places.
    }


    [CreateAssetMenu(fileName = "New Item", menuName = "SF/Inventory/ItemData")]
    public class ItemDTO : ScriptableObject
    {
        public ItemGeneralDTO GeneralInformation;
        public ItemSubType ItemSubType;
        public ItemPriceDTO PriceData;
    }
}