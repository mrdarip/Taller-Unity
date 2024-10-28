using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        rb.AddForce(
            new Vector3(
                Input.GetAxis("Horizontal"), 
                0,
                Input.GetAxis("Vertical")
            )
            * velocidad
        );
    }
}
