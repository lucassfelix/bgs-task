using System.Collections.Generic;
using UnityEngine;

namespace Code.Inventory
{
    public class ItemCarousel : MonoBehaviour
    {
        [Header("Settings")] 
        public int inventorySpaces;

        public GameObject itemSpacePrefab;

        private List<ItemSpace> _items; 
        
        public void Start()
        {
            for (int i = 0; i < inventorySpaces; i++)
            {
                Instantiate(itemSpacePrefab, transform);
            }
        }
    }
}
