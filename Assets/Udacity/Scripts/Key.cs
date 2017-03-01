using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    public GameObject theDoor;

    void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
        //I made my key spin using a Unity animation for now
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Instantiate(keyPoof, transform.position, Quaternion.Euler(-90, 0, 0));
        // Call the Unlock() method on the Door
        theDoor.GetComponent<Door>().Unlock();
        // Set the Key Collected Variable to true?

        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject, 0.2f);
    }

}
