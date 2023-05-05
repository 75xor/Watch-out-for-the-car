using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movespeed = 5.0f;
    [SerializeField] private float turnspeed = 60.0f;

    new Rigidbody rigidbody;
    public bool UPysics = false;
    public float moveforce = 300.0f;

    public GameObject bulletprefab;
    float turnvelocity;
    Vector3 offset = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
   
    void Update()
    {
        offset = Vector3.zero;
  

        if (Input.GetKey(KeyCode.D)) offset += transform.right * Time.deltaTime * movespeed;
        if (Input.GetKey(KeyCode.A)) offset -= transform.right * Time.deltaTime * movespeed;
        if (Input.GetKey(KeyCode.W)) offset += transform.forward * Time.deltaTime * movespeed;
        if (Input.GetKey(KeyCode.S)) offset -= transform.forward * Time.deltaTime * movespeed;

        if (Input.GetKey(KeyCode.Q)) transform.Rotate(Vector3.down * turnspeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.E)) transform.Rotate(Vector3.up * turnspeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = GameObject.Instantiate<GameObject>(bulletprefab, transform.position, transform.rotation);
            GameObject.Destroy(bullet, 5.0f);
        }
        if (Input.GetKeyDown(KeyCode.R)) transform.eulerAngles += new Vector3(0, 45.0f, 0);



        if (!UPysics) transform.position += offset;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "wall")
        {
            rigidbody.velocity = Vector3.zero;
        }
    }
}

