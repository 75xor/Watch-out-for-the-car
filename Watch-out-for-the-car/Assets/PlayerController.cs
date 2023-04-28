using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movespeed = 2.0f;
    [SerializeField] private float turnspeed = 30.0f;

    new Rigidbody rigidbody;
    public bool userPysics = false;
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

        if (Input.GetKeyDown(KeyCode.RightArrow)) offset += Vector3.right * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) offset += Vector3.left * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.UpArrow)) offset += Vector3.up * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.DownArrow)) offset += Vector3.down * Time.deltaTime;
  

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

        float herizontal = Input.GetAxis("Mouse X");
        transform.Rotate((herizontal * turnspeed * 0.3f) * Vector3.up);

        if (!userPysics) transform.position += offset;
    }

    void OnMouseDown()
    {
        print("mouse down");
    }
    void FixedUpdate()
    {
        if (userPysics) rigidbody.AddForce(offset * movespeed);
    }
}

