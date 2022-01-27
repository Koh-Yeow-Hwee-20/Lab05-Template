using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject Coins;
    private int coinCount;
    int Totalcoin = 60;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (coinCount == Totalcoin)
        {
            SceneManager.LoadScene("WinScene");
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
