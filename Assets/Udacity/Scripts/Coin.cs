using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject coinPoof;

    public void OnCoinClicked() {
        Instantiate(coinPoof, transform.position, Quaternion.Euler(-90, 0, 0));
        Destroy(gameObject, 0.2f);
    }

}
