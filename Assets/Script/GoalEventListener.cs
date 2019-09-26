using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalEventListener : MonoBehaviour
{
    public GameObject ball;
    public GameObject reticle;
    public int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnGrab()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            score += 1;
            //update UI
            scoreText.text = "Score : " + score;
        }
    }
}
