using UnityEngine;
using UnityEngine.UI;

public class Fuel : MonoBehaviour
{

    //public Text fueltex;
    public float fuel = 100f;
    public float fueldrag = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") && fuel > 0f)
        {
            fuel -= fueldrag * Time.deltaTime;
            //fueltex.text = fuel.ToString("0");
        }
    }
}
