using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Inheritance structure is a "Is-A" relationship"
 */

public class Mammal
{
    public bool LaysEggs = false;    
}

public class Dog : Mammal
{
    public bool BiPedal = false;
}


public class Human : Mammal
{
    public static bool BiPedal = true;
    public string Gender;
    public int Age;

    // static is useful for changing a property of 
    // all instances of a class created in a program
    public static bool FreeWill;

    public static void ChangeFreeWill()
    {
        // switches between true and false
        FreeWill = !FreeWill;

        // static member cannot access instance member
        //Age = 21;
    }

}
