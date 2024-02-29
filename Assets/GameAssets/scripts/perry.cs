using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perry : MonoBehaviour
{
public float fuerza = 50;
private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
           rb.AddForce(new Vector3(0,fuerza,0));
        }   
    }
}
