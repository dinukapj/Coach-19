using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    float timer = 0.0f;
    public Rigidbody projectile;
    public float speed = -10.0f;
    public bool starttimer;
    public Transform originalBallPosition;
    public GameObject reticle;
    public GameObject goalie;
    public float kickStrength;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !starttimer)
        {
            // projectile.velocity = transform.right * speed;
            Vector3 heading = reticle.transform.position - transform.position;
            heading = heading.normalized;
            // Vector3 force = Vector3.Project(heading, transform.right);
            projectile.AddForce(heading * kickStrength);
            starttimer = true;
        }
        if (starttimer == true)
        {
            timer += Time.deltaTime;
        }
        if (timer > 2.0f)
        {
            starttimer = false;
            projectile.velocity = Vector3.zero;
            projectile.transform.position = originalBallPosition.position;
            timer = 0.0f;
        }
    }
}
