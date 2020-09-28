using UnityEngine;
using System;

public class Swing : MonoBehaviour
{

    public Transform swinger;
    public Vector3 offset;
    public float change = 0.01f;
    //private bool limit = false;
    //public float lchange = 1f;

    // Start is called before the first frame update
    void Start()
    {
        offset = swinger.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(swinger.position.z) >= 12)
        {
            change *= -1f;
        }

        offset.z += change;
        transform.position = offset;

        //Debug.Log(swinger.position);

    }
}
