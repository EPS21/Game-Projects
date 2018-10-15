using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public GameObject CubeReference;
    float Speed = 0.01f;
    Vector3 CubeRefPosition;
    
    public int Timer;

	// Use this for initialization
	void Start ()
    {
        // Dynamic Reference to our Cube/Player1 GameObject
        //CubeReference = GameObject.Find("Cube1");        
        Timer = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
        EnemyProximity();
        SpawnEnemy();

	}

    private void Movement()
    {
        // Sphere tracks position of player1 and follows
        CubeRefPosition = CubeReference.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, CubeRefPosition, Speed);

    }

    private void EnemyProximity()
    {
        // Check Distance between player1 & enemy
        float x = transform.position.x - CubeRefPosition.x;
        float y = transform.position.y - CubeRefPosition.y;
        Vector2 distance = new Vector2(x, y);


        // If occupying same space as you, you've been eaten        
        if (((distance.x < 0.1f) && (distance.x > -0.1f)) &&
            ((distance.y < 0.1f) && (distance.y > -0.1f)))
        {
            GameObject.Destroy(CubeReference);
            //Debug.Log("You have been eaten!");
        }
    }

    private void SpawnEnemy()
    {
        // Spawn duplicate enemies every 500 tick
        if (Timer % 250 == 0)
        {
            //Vector3 RandomSpawn;
            float x = Random.Range(-6.2f, 6.2f);
            float y = Random.Range(-3.4f, 3.4f);
            float z = transform.position.z;
            GameObject.Instantiate(this.gameObject, new Vector3(x, y, z), transform.rotation); // this.gameObject 'this' is for making another sphere object (and not something else)
        }
        Timer++;
    }
}
