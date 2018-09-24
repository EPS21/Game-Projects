using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGController : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //MethodInputsAndReturns();
        //ValueVsReference();
        Polymorphism();
    }   

    void MethodInputsAndReturns()
    {
        Wizard wizard = new Wizard();
        wizard.weapon.WeaponType = "Rod";

        //string offenseMessage = wizard.weapon.UseWeapon();
        //Debug.Log(offenseMessage);

        Knight knight = new Knight();
        knight.weapon.WeaponType = "2-Handed Sword";

        string defenseMessage = wizard.weapon.Deflect(knight, 30);
        Debug.Log(defenseMessage);
    }

    void ValueVsReference()
    {
        /*
        // Value types
        int num1 = 0;
        int num2 = num1;
        num2 = 99;
        Debug.Log("num1: " + num1); // outputs 0

        // Reference types
        Wizard wiz1 = new Wizard();
        wiz1.weapon.WeaponType = "Staff";
        Wizard wiz2 = wiz1;
        wiz2.weapon.WeaponType = "Orb";
        Debug.Log("wizard1: " + wiz1.weapon.WeaponType); // outputs staff? no its Orb!
        */

        Wizard wizard = new Wizard();
        Knight knight = new Knight();
        knight.weapon.WeaponType = "Spoon";

        string defenseMessage = wizard.weapon.Deflect(knight, 30);
        Debug.Log(knight.weapon.WeaponType);


    }

    void Polymorphism()
    {
        Wizard wizard = new Wizard();
        Knight knight = new Knight();
        Elf elf = new Elf();

        knight.weapon.WeaponType = "Spoon";
        elf.weapon.WeaponType = "Arrow";

        Combatant combatant = knight;

        string defenseMessage = wizard.weapon.Deflect(combatant, 25);
        Debug.Log(defenseMessage);

        //object anObject = elf;
        wizard.weapon.DamageSomething(elf);

        Companion spiritFamiliar = new Companion();
        wizard.weapon.DamageSomething(spiritFamiliar);
    }
	
}
