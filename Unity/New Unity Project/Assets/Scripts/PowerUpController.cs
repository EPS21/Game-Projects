using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    // create a reference to the cube
    GameObject CubeReference;    
    public int Timer = 1;

	// Use this for initialization
	void Start ()
    {
        CubeReference = GameObject.Find("Cube1");              
	}
	
	// Update is called once per frame
	void Update ()
    {
        DestroyPowerUp();
    }

    private bool AtePowerUp()
    {
        // Eat or Destroy PowerUp
        Vector2 distance = new Vector2(
            transform.position.x - CubeReference.transform.position.x,
            transform.position.y - CubeReference.transform.position.y
        );

        // If occupying same space as you, you've been eaten
        // The 0.5f is collision hitbox, lower value makes it harder to touch
        if (((distance.x < 0.5f) && (distance.x > -0.5f)) &&
            ((distance.y < 0.5f) && (distance.y > -0.5f)))
            return true;
        else
            return false;
    }

    private void DestroyPowerUp()
    {
        Timer++;

        if (AtePowerUp())
        {
            GameObject.Destroy(gameObject);
            PowerUpManager.PowerUpMeter += 100;
            Debug.Log(PowerUpManager.PowerUpMeter);
        }

        if (Timer % 140 == 0)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
