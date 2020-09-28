using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breathing : MonoBehaviour
{

    public Transform refill;
    private float change = 0.001f;
    private Vector3 size = new Vector3 (0.75f, 0.75f, 0.75f);


    // Start is called before the first frame update
    void Start()
    {
        //refill = GameObject.Find("Refill");
    }

    // Update is called once per frame
    void Update()
    {
        //refill.GetComponent<Transform>().lossyScale += 
        if (size.x >= 1 || size.x <= 0.5)
        {
            change *= -1;
        }

        size.x += change;
        size.y += change;
        size.z += change;
        transform.localScale = size;




        //transform.localScale += size; 
    }
}
