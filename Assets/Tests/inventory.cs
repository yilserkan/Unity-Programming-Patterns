using NUnit.Framework;
using ProgrammingPatterns;

public class inventory 
{
    [Test]
    public void only_allows_one_chest_to_be_equipped_at_the_same_time()
    {
        Inventory _inventory = new Inventory();
        Item chestOne = new Item(){equipSlot = EquipSlots.Chest, Armor = 10};
        Item chestTwo = new Item(){equipSlot = EquipSlots.Chest, Armor = 20};
        
        _inventory.EquipItem(chestOne);
        _inventory.EquipItem(chestTwo);

        Item equippedItem = _inventory.GetEquippedItem(EquipSlots.Chest);
        
        Assert.AreEqual(chestTwo, equippedItem);
    }
}