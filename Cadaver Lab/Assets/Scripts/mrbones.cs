using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mrbones : MonoBehaviour
{
    [SerializeField] private Text myText; //SerializeField allows option to show in the inspector; named the image I will use myImage

    void OnTriggerEnter(Collider other) //when player encounters the trigger
    {
        if (other.CompareTag("Player")) //my camera tagged as player will initiate this function
        {
            myText.enabled = true; //image will appear
        }
    }

    void OnTriggerExit(Collider other) //when player leaves the trigger
    {
        if (other.CompareTag("Player")) //my camera tagged as player will initiate this function
        {
            myText.enabled = false; //image will disappear
        }
    }
}

//script created with https://www.youtube.com/watch?v=UVUMqss4A34