using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnBreakScript : MonoBehaviour
{


    public GameObject unbrokenColumn;
    public GameObject brokenColumn;

    //this determines whether the column will be broken or unbroken at the at runtime
    public bool isBroken;


    void Start()
    {
        if (isBroken)
        {
            BreakColumn();
        }
        else
        {
            unbrokenColumn.SetActive(true);
            brokenColumn.SetActive(false);
        }
    }


    void BreakColumn()
    {
        isBroken = true;
        unbrokenColumn.SetActive(false);
        brokenColumn.SetActive(true);
    }

    //private void OnTriggerEnter(Collider other)
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Damaging")
        {
            if (!isBroken)
            {
                BreakColumn();
            }
        }
          
    }

    void Update()
    {

    }
}