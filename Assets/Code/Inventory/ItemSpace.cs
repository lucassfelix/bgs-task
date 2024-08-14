using System;
using Code.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Inventory
{
    public class ItemSpace : MonoBehaviour
    {
        private ItemObject _currentObject;
        private Image _iconImage;

        private void Start()
        {
            _iconImage = GetComponentsInChildren<Image>()[1];
            UpdateImage();
        }

        public void PlaceItem(ItemObject newItem)
        {
            _currentObject = newItem;
            UpdateImage();
        }

        public void RemoveItem()
        {
            
        }
        
        private void UpdateImage()
        {
            if (_iconImage == null)
            {
                _iconImage = GetComponentsInChildren<Image>()[1];
            }

            if (_currentObject == null)
            {
                _iconImage.enabled = false;
                return;
            }
            
            _iconImage.enabled = true;
            _iconImage.sprite = _currentObject.icon;
        }

        public bool IsEmpty()
        {
            return _currentObject == null;
        }
    }
}
