using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] private Image myImage; //SerializeField allows option to show in the inspector; named the image I will use myImage

    void OnTriggerEnter(Collider other) //when player encounters the trigger
    {
        if (other.CompareTag("Player")) //my camera tagged as player will initiate this function
        {
            myImage.enabled = true; //image will appear
        }
    }

    void OnTriggerExit(Collider other) //when player leaves the trigger
    {
        if (other.CompareTag("Player")) //my camera tagged as player will initiate this function
        {
            myImage.enabled = false; //image will disappear
        }
    }
}
