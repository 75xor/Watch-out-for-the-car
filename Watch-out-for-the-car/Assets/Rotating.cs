using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    public GameObject spherePrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere = GameObject.Instantiate<GameObject>(spherePrefab, new Vector3(3.0f, 0.0f, 0.0f),Quaternion.identity,transform);
        sphere.name = name+" Sphere";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f); //1초에 90도 y축으로
    }
}
