using UnityEngine;

public class Seeing : MonoBehaviour
{


    public Transform player;
    public bool seen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(UnityEngine.Vector3.Distance(player.position, transform.position));
        if (UnityEngine.Vector3.Distance(player.position, transform.position) < 5)
        {
            seen = true;
        }
    }
}
