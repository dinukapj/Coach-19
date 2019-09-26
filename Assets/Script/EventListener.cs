using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject reticle;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnGrab()
    {
        Instantiate(myPrefab, reticle.transform.position, Quaternion.identity);
    }
}
