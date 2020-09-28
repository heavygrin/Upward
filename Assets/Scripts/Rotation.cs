using UnityEngine;

public class Rotation : MonoBehaviour
{

    public Transform rotator;
    public Vector3 offset;
    //public Quaternion rotation;
    public float rotatespeed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset.y += rotatespeed;
        transform.rotation = Quaternion.Euler(offset);
        //Debug.Log(transform.rotation);
    }
}
