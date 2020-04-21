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
    Quaternion currentRotation;
    int frameCount;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        currentRotation = new Quaternion();
        frameCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (frameCount >= 20)
        {
            currentRotation = rb.transform.rotation;
            currentRotation.Set(0, currentRotation.y, 0, currentRotation.w);
            frameCount = 0;
        }
        frameCount++;
    }
}
