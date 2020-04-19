using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(new Vector3(0, -5, 0), Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(new Vector3(0, 5, 0), Space.Self);
        }
    }
}
