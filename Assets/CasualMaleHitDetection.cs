using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasualMaleHitDetection : MonoBehaviour
{
    Rigidbody rb;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Damaging")
        {
            Debug.Log("CasualMale he got hit!");
            rb.constraints = RigidbodyConstraints.None;
            animator.SetBool("IsDown", true);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        //
        //Reason for having OnTrigger when OnCollision already exists?
        //This OnCollision boxes are small and on key body parts only (hands, feet, head, spine)
        //So we need this bigger encompassing trigger box to detect when hits occur because
        //the smaller colliders are not a big enough attack surface
        //
        if (other.tag == "Damaging")
        {
            Debug.Log("CasualMale he got hit!");
            rb.constraints = RigidbodyConstraints.None;
            animator.SetBool("IsDown", true);
        }

    }

}
