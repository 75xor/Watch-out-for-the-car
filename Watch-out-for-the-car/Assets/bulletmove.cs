using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    public float speed = 5.0f;
    int wallLayer = 7;
    // Start is called before the first frame update
    void Start()
    {
        wallLayer = LayerMask.NameToLayer("wall");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject + " : " + other.gameObject.layer);
        if (other.gameObject.layer == wallLayer)
        {
            GameObject.Destroy(gameObject, 0.0f);
            Debug.Log("Triggered");
        }
    }
}
