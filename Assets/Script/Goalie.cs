using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalie : MonoBehaviour
{
    private bool atCornerA = true;
    public float runSpeed = 2.0f;

    void Start()
    {

    }

    void Update()
    {
        if (atCornerA)
        {
            transform.position += Vector3.right * Time.deltaTime * runSpeed;
        }
        else
        {
            transform.position += Vector3.left * Time.deltaTime * runSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Corner A" || other.tag == "Corner B")
        {
            //move to next corner
            if (atCornerA)
            {
                atCornerA = false;
            }
            else
            {
                atCornerA = true;
            }
        }
    }
}
