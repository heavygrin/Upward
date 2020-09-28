using UnityEngine;

public class Refill : MonoBehaviour
{

    private GameObject player;
    //private float fuel;


    // Start is called before the first frame update
    void Start()
    {
        //fuel = player.GetComponent<Fuel>().fuel;
        player = GameObject.Find("Player");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player")
        {
            Destroy(gameObject);
            player.GetComponent<Fuel>().fuel += 40f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
