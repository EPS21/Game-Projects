using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour {

    int HealthPoints = 100;

	void Start ()
    {
        DealDamage();
        DealDamage();
        Debug.Log(HealthPoints);
	}
	
	void DealDamage()
    {
        HealthPoints -= 5;
    }
}
