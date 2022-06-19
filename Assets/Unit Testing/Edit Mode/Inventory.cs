
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ProgrammingPatterns
{
    public class Inventory
    {
        [SerializeField] private Dictionary<EquipSlots, Item> _equippedItems = new Dictionary<EquipSlots, Item>();
        private List<Item> _unequippedItems = new List<Item>();

        public void EquipItem(Item item)
        {
            if (_equippedItems.ContainsKey(item.equipSlot))
            {
                _unequippedItems.Add(_equippedItems[item.equipSlot]);
            }

            _equippedItems[item.equipSlot] = item;
        }

        public float GetTotalArmor()
        {
            int totalArmor = _equippedItems.Values.Sum(t => t.Armor);
            return totalArmor;
        }

        public Item GetEquippedItem(EquipSlots equipSlots)
        {
            if(_equippedItems.ContainsKey(equipSlots))
                return _equippedItems[equipSlots];
            return null;
        }
    }
}
