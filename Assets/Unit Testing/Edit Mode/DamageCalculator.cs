using System;

public static class DamageCalculator 
{
    public static int CalculateDamage(int amount ,float mitigationPercent)
    {
        float damageMultiplier = 1 - mitigationPercent;
        int takenDamage = Convert.ToInt32(amount * damageMultiplier);
        return takenDamage;
    }

    public static int CalculateDamage(int amount, ICharacter character)
    {
        float totalArmor = character._inventory.GetTotalArmor();
        float armorProtectionAmount = 100 - totalArmor;
        float multiplier = armorProtectionAmount / 100f;
        int takenDamage = Convert.ToInt32(amount * multiplier);
        return takenDamage;
    }
}
