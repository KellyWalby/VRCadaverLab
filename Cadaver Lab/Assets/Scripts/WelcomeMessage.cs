using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class welcomeMessage : MonoBehaviour
{
    [SerializeField] private Image myImage; //SerializeField allows option to show in the inspector; named the image I will use myImage

    void OnTriggerEnter(Collider other) //when player encounters the trigger
    {
        //Debug.Log("Object enters");
        if (other.CompareTag("Player")) //my camera tagged as player will initiate this function
        {
            myImage.enabled = true; //image will appear
        }
    }

    void OnTriggerExit(Collider other) //when player leaves the trigger
    {
        //Debug.Log("Object leaves");
        if (other.CompareTag("Player")) //my camera tagged as player will initiate this function
        {
            myImage.enabled = false; //image will disappear
        }
    }
}

//script created with https://www.youtube.com/watch?v=UVUMqss4A34