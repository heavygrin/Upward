using UnityEngine;
using UnityEngine.UI;
using System;

public class Bar : MonoBehaviour
{

    //private GameObject fuelbar;
    public Image fuelbar;
    private GameObject player;
    private float f;

    //public Fuel fuel;
    //private float f = 1f;
    //public Vector4 firstcolor;
    //public Vector4 secondcolor;


    //private float fill = 100f;

    // Start is called before the first frame update
    void Start()
    {
        //fuelbar = GameObject.Find("Fuelbar");
        player = GameObject.Find("Player");
        //fuelbar.GetComponent<Image>().fillAmount = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {


        fuelbar.fillAmount = player.GetComponent<Fuel>().fuel/100f;
        //Debug.Log(fuelbar.GetComponent<Image>().fillAmount);

        //Debug.Log(player.GetComponent<Fuel>().fuel);
        //f = fuelbar.fillAmount;
        //Debug.Log(f);

        f = fuelbar.fillAmount;

        if( f > 0.7f)
        {
            fuelbar.GetComponent<Image>().color = new Color32(32, 35, 89, 255);
        }

        if (f <= 0.7f && f > 0.3f)
        {
            fuelbar.GetComponent<Image>().color = new Color32(117, 195, 156, 250);
        }

        else if (f <= 0.3f)

            fuelbar.GetComponent<Image>().color = new Color32(150, 42, 44, 250);

        //fuelbar.color = f <= 0.7f && f > 0.3f ? Color.green : Color.red;
        //Debug.Log(fuel.fuel/100f);
    }
}
