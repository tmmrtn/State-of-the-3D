using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Rigidbody rb;
    Vector3 currentPos;
    Quaternion currentRot;
    Outline playerOutline;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        playerOutline = GameObject.FindObjectOfType<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindWithTag("Damaging"))
        {
            playerOutline.OutlineColor = new Color(255, 0, 0);
        }
        else
            playerOutline.OutlineColor = new Color(255, 255, 255);

        if (Input.GetKey(KeyCode.W))
        {
            currentPos = rb.transform.position;
            currentRot = Quaternion.Euler(0, 180, 0);

            if (Input.GetKey(KeyCode.A))
                currentRot = Quaternion.Euler(0, 135, 0);

            else if (Input.GetKey(KeyCode.D))
                currentRot = Quaternion.Euler(0, 225, 0);            

            rb.transform.SetPositionAndRotation(currentPos, currentRot);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            currentPos = rb.transform.position;
            currentRot = Quaternion.Euler(0, 90, 0);

            if (Input.GetKey(KeyCode.W))
                currentRot = Quaternion.Euler(0, 135, 0);

            else if (Input.GetKey(KeyCode.S))
                currentRot = Quaternion.Euler(0, 45, 0);

            rb.transform.SetPositionAndRotation(currentPos, currentRot);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentPos = rb.transform.position;
            currentRot = Quaternion.Euler(0, 0, 0);

            if (Input.GetKey(KeyCode.A))
                currentRot = Quaternion.Euler(0, 45, 0);

            else if (Input.GetKey(KeyCode.D))
                currentRot = Quaternion.Euler(0, 315, 0);

            rb.transform.SetPositionAndRotation(currentPos, currentRot);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            currentPos = rb.transform.position;
            currentRot = Quaternion.Euler(0, 270, 0);

            if (Input.GetKey(KeyCode.W))
                currentRot = Quaternion.Euler(0, 225, 0);

            else if (Input.GetKey(KeyCode.S))
                currentRot = Quaternion.Euler(0, 315, 0);

            rb.transform.SetPositionAndRotation(currentPos, currentRot);
        }
    }
}
