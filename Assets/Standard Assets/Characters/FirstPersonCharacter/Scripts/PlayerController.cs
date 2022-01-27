using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //public Gameobject Coins;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //Collision for Coins
        if (other.gameObject.tag == "Coin")
        {
            //coinCount++;
            //Coins.GetComponent<Text>().text = "Coins Collected = " + coinCount;

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameScene");
        }

    }
}
