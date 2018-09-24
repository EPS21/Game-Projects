using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalFactory : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Human person = new Human();
        Human.BiPedal = true;
        //Debug.Log(person.LaysEggs);

        Human.FreeWill = false;        
        Human.ChangeFreeWill();        
        Debug.Log(Human.FreeWill);

        
	}
	
	
}
