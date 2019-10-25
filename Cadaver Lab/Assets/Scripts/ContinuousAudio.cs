using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuousAudio : MonoBehaviour
{
    private void Awake() //while Oculus is awake
    {
        DontDestroyOnLoad(transform.gameObject); //keeps the audio from stopping after scene change
    }
}
//retrieved from youtube.com/watch?v=BKCsH8mQ-IM