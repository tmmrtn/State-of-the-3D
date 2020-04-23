using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignXZRotation : MonoBehaviour
{
    //
    // Purpose of script. For now its a hack to solve a problem/
    // Problem: after punching columns, the x and z orienation of the player tilt a bit off axis.
    // When tilted the char can't walk properly.
    // So this script periodically reset the x and z rotation to zero.
    //

    Rigidbody rb;
    Vector3 currentPos;
    Quaternion currentRot;
    int frameCount;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        frameCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (frameCount >= 20)
        {
            currentPos = rb.transform.position;
            currentRot = rb.transform.rotation;
            //reset x and z to zero, leaving y as it was.
            currentRot = Quaternion.Euler(0, currentRot.eulerAngles.y, 0);
            rb.transform.SetPositionAndRotation(currentPos, currentRot);
            frameCount = 0;
        }
        frameCount++; 
    }
}
