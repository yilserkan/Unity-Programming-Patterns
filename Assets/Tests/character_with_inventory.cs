using NUnit.Framework;
using ProgrammingPatterns;
using UnityEngine.TextCore.Text;

public class character_with_inventory
{
    [Test]
    public void with_90_armor_takes_10_percent_damage()
    {
        MockCharacter character = new MockCharacter();
        Inventory inventory = new Inventory();

        Item chestPlate = new Item() { equipSlot = EquipSlots.Chest, Armor = 40 };
        Item pants = new Item() { equipSlot = EquipSlots.Legs, Armor = 50 };
        
        inventory.EquipItem(chestPlate);
        inventory.EquipItem(pants);

        character._inventory = inventory;

        int calculateDamage = DamageCalculator.CalculateDamage(1000, character);
        
        Assert.AreEqual(100, calculateDamage);

    }
    
}