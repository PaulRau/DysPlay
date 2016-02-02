using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderVolumeMusic : MonoBehaviour {


    Text musicslider; //pour le slider du volume



    void Awake()
    {
        // Set up the reference.
        musicslider = GetComponent<Text>();




    }

    void Start()
    {

    }

    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        musicslider.text = "Volume de la musique : " + MenuScript.currentMusicVolume;
    }
}
