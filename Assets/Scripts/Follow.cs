using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public Transform player;
    public float MoveSpeed = 2f;
    private bool caught = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player")
        {
            caught = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        if(!caught)
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        //if(transform.position.x - player.position.x)
    }
}
