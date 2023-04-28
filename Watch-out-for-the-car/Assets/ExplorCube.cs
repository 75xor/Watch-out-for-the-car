using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplorCube : MonoBehaviour
{
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.onUnitSphere;
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * 10.0f * Time.deltaTime);
        transform.Rotate(direction * 300.0f * Time.deltaTime);
    }
}
