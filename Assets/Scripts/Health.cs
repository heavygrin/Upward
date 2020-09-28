using UnityEngine;

public class Health : MonoBehaviour
{

    public float health = 100f;
    public bool iscollide = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            iscollide = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (iscollide)
        {
            health -= 20f;
            //Debug.Log(health);
            iscollide = false;
        }
    }
}
