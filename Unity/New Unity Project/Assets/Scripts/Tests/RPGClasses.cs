using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * tHE Wizard having a weapon is an example of a "Has-A" relationship
 * or 'containment,' the classes are seperate but related, and is an 
 * example of abstraction (hiding away Weapon's implementation)
 */

public class NPC { }
public class Companion : NPC { }

public class Combatant
{
    public Weapon weapon = new Weapon();
}

public class Wizard : Combatant { }
public class Knight : Combatant { }
public class Elf : Combatant { }

public class Weapon
{
    public string WeaponType;
    private int Degradation = 100;

    public string UseWeapon()
    {
        string phrase = "The player struck with the weapon: ";
        string combinedPhrase = phrase + WeaponType;
        return combinedPhrase;
    }

    public string Deflect(Combatant combatant, int degradation)
    {
        
        Degradation -= degradation;

        string phrase = string.Format(
            "You deflected the {0}'s {1} and " +
            "degraded your weapon to {2}",
            combatant.GetType(),
            combatant.weapon.WeaponType,
            Degradation
            );

        combatant.weapon.WeaponType = "Broken " + combatant.weapon.WeaponType;
        return phrase;
        
        // below is for a string input parameter, rather than an object
        //return weaponType = "Broken " + weaponType;

    }

    public void DamageSomething(object anObject)
    {
        // do something that damages the object
    }
}
