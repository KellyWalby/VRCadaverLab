using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRButton : MonoBehaviour
{
    public Image BackgroundImage;
    public Color NormalColor;
    public Color HighlightColor; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGazeEnter()
    {
        BackgroundImage.color = HighlightColor;
    }

    public void onGazeExit()
    {
        BackgroundImage.color = NormalColor;
    }
}
