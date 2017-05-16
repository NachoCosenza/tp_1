using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girar : MonoBehaviour {

    private Rigidbody rb;
    public float angle;
    public GameObject prefa;
    public Transform salida;
    public float fuerza;

    // Use this for initialization
    void Start ()
    {

        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * angle);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -angle);
        }

        ////////////////////

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * angle);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * -angle);
        }

        
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddRelativeForce(Vector3.up * fuerza);
            }
        

        

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * angle);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * -angle);
        }


    }
}
