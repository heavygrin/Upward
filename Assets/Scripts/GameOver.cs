using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    private GameObject player;
    private GameObject mcamera;
    private GameObject gameovertex;
    public Seeing watcher;
    private float health;
    private float y;
    private float x;
    private float camerax;
    private bool gameover = false;
    private bool followed = false;
    private float timelapse = 0;
    private readonly float overtime = 2;
    private float cooltime;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        mcamera = GameObject.Find("Main Camera");
        //private Health health = GameObject.FindObjectOfType<Health>();

        gameovertex = GameObject.Find("Gameover");
    }

    

    // Update is called once per frame
    void Update()
    {
        timelapse += Time.deltaTime;

        health = player.GetComponent<Health>().health;

        y = player.GetComponent<Transform>().position.y;

        x = player.GetComponent<Transform>().position.x;

        followed = player.GetComponent<PlayerMovement>().followercatch;

        camerax = mcamera.GetComponent<Transform>().position.x;

        if ((health <= 0f || y <= 0f || camerax - x > 10 ||  followed || watcher.seen) && !gameover)
        {
            gameover = true;
            cooltime = timelapse + overtime;
            gameovertex.GetComponent<Text>().enabled = true;
        }

        if (gameover && timelapse >= cooltime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
