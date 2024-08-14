using UnityEngine;

namespace Code.ScriptableObjects
{
    public class ItemObject : ScriptableObject
    {
        [Header("Common")]
        public string itemName;
        public string description;
        public Sprite icon;
    }
}
