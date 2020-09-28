using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text playerscore;
    private float x = 0f;
    private float score = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //x = player.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.x + 175f >= x)
        {
            score += (player.position.x + 175f)- x;
            x = player.position.x + 175f;
            //Debug.Log(score);
            playerscore.text = x.ToString("0");
        }
        
    }
}
