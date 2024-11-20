using UnityEngine;

namespace SF.Inventory
{
    [System.Serializable]
    public class ItemGeneralDTO : DTOBase
    {
        public int ID = 0;
        public string ItemGUID;
        public string ItemName = "New Item";
        public string ItemDescription = "This is an item";
        public Sprite ItemIcon;
    }
}
