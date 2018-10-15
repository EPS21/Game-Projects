using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject PowerUpPrefab;
    int Timer;
    public static int PowerUpMeter;

	// Use this for initialization
	void Start ()
    {
        Timer = 1;
        PowerUpMeter = 50; // default 'bonus' at startup  
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Timer % 300 == 0)
        {
            Vector3 randomSpawn = new Vector3(
            Random.Range(-6.2f, 6.2f),
            Random.Range(-3.4f, 3.4f),
            transform.position.z
            );

            GameObject.Instantiate(PowerUpPrefab, randomSpawn, transform.rotation);
        }
        Timer++;               
    }
}
