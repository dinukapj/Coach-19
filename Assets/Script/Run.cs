using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Run : MonoBehaviour
{
    public Animator animation;
    public float runSpeed = 2.0f;
    private bool lookingForward = true;

    void Start()
    {
        animation = GetComponent<Animator>();
    }

    void Update()
    {
        animation.Play("run");
        if (lookingForward)
        {
            transform.position += Vector3.forward * Time.deltaTime * runSpeed;
        }
        else
        {
            transform.position += Vector3.back * Time.deltaTime * runSpeed;
        }
    }

    public void moveleftright()
    {
        transform.position -= Vector3.right * Time.deltaTime * 1.50f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Field End" || other.tag == "Field Start")
        {
            //turn around and run back
            if (lookingForward)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
                lookingForward = false;
            }
            else
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);
                lookingForward = true;
            }
        }
    }
}
