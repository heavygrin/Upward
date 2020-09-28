using UnityEngine;

public class OnCollide : MonoBehaviour
{

    public Transform player;
    public Transform obstacle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player")
        {
            if(player.position.x <= obstacle.position.x)
            Destroy(gameObject, 0.2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
