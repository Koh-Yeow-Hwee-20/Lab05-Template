using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //Coin and Score
    public GameObject Coins;
    private int coinCount;
    int Totalcoin = 60;

    //Time
    public float timeleft;
    public int timeRemaining;
    public Text Timertext;
    private float TimerValue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        timeRemaining = Mathf.FloorToInt(timeleft % 60);
        Timertext.text = "Time: " + timeRemaining.ToString();

        if (coinCount == Totalcoin)
        {
            SceneManager.LoadScene("WinScene");
        }
        else if (timeleft <= 0.5f)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Collision for Coins
        if (other.gameObject.tag == "Coin")
        {
            coinCount+= 10;
            Coins.GetComponent<Text>().text = "Score: " + coinCount;

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("LoseScene");
        }

    }
}
