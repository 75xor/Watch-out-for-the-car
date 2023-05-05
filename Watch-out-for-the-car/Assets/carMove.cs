using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour
{


    public Vector3 direction = Vector3.up; 
    public float distance = 10f; 
    public float speed = 2f; 
    public int health = 100;
    public GameObject objectToSpawn; 
    public int count = 100;
    private Vector3 startingPosition; 
    private float t; 

    private void Start()
    {
        startingPosition = transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health -= 50;
            if (health <= 0) 
            {
                Destroy(gameObject);
                for (int x = 0; x <= count; x++)
                {
                    GameObject newObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);
                }
            }
        }
    }
    private void Update()
    {
        t += Time.deltaTime * speed;
        transform.position = startingPosition + direction * Mathf.PingPong(t, distance);
      
    }
}
