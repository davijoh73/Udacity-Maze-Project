using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    //The locked variable is used in the Unlock method to "unlock" the door
    public bool locked = true;
    //Trigger used to open the door once it's unlocked
    public bool openDoor = false;
    //Sound clips used for when the door is locked, and when it's opened
    public AudioSource soundSource;
    public AudioClip doorLocked;
    public AudioClip doorOpen;

    void Update() {
        //I don't need this - I will open the doors using an animation script instead
    }

    public void OnDoorClicked() {
        if (locked == false)
        {
            //Trigger the door to open via animation script
            openDoor = true;
        }
        else
        {
            //Play locked door audio clip
            soundSource.clip = doorLocked;
            soundSource.Play();
        }
    }

    public void Unlock()
    {
        //Call this method to unlock the door - like when you find the key
        locked = false;
    }
}
