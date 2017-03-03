using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject coinPoof;
    //Integer variable to track number of coins collected
    public static int coinsCollected = 0;

    public void OnCoinClicked() {
        Instantiate(coinPoof, transform.position, Quaternion.Euler(-90, 0, 0));
        Destroy(gameObject, 0.2f);
        //Add another coin to the total number collected so far
        coinsCollected = coinsCollected + 1;
        //Debug.Log("Number of coins in your purse: " + coinsCollected);
    }

}
