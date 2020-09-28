using UnityEngine;

public class CameraPos : MonoBehaviour
{

    public Transform playerpos;
    public float speed;
    public float camfix;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        camfix = playerpos.position.x;
        offset.x = playerpos.position.x;
        transform.position = offset;
        //GameObject sp = GameObject.Find("Player");
        //PlayerMovement playermovement = sp.GetComponent<PlayerMovement>();
        //speed = playermovement.forwardforce;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerpos.position.x >= camfix)
        {
            offset.x = playerpos.position.x;
            camfix = offset.x;
            transform.position = offset;
        }
        

    }
}
