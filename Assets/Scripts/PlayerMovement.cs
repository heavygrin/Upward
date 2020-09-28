using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public Seeing watcher;
    public float forwardforce = 400f;
    public float backwardforce = 300f;
    public float backlimit = 1000f;
    public float drag = 5f;
    public float dodgeforce = 200f;
    public float cooldown = 0.5f;
    private float timelapse = 0;
    private float cooltime;
    private float fuelremain;
    public bool followercatch = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Follower"))
        {
            followercatch = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        timelapse += Time.deltaTime;

        fuelremain = GetComponent<Fuel>().fuel;


        // If "W" is pressed , the jetpack will add force
        if (Input.GetKey("w") && fuelremain > 0f)
        {
            if (!followercatch && !watcher.seen)
            {
                rb.AddForce(forwardforce * Time.deltaTime, 0, 0);
            }

            backwardforce = 300f;
        }
            

        // As long as "W" is not pressed, the backward force will drag
        else
        {
            if (!followercatch && !watcher.seen)
            {
                rb.AddForce(-backwardforce * Time.deltaTime, 0, 0);
            }

            if (backwardforce < backlimit)
            backwardforce = backwardforce + drag;
        }


        // If "A" is pressed, the player will dodge to the left side
        if (Input.GetKey("a") && timelapse >= cooltime)
        {
            //Debug.Log("Yes");
            if (!followercatch && !watcher.seen)
            {
                rb.AddForce(0, 0, dodgeforce);
            }

            cooltime = timelapse + cooldown;
        }

        

        //If "D" is pressed, the player will dodge to the right side
        if (Input.GetKey("d") && timelapse >= cooltime)
        {
            if (!followercatch && !watcher.seen)
            {
                rb.AddForce(0, 0, -dodgeforce);
            }

            cooltime = timelapse + cooldown;
        }

        

        //Debug.Log(timelapse);
        //Debug.Log(cooltime);
    }
}
