using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderVolume : MonoBehaviour {

   Text text; //pour le slider du volume

  

    void Awake()
    {
        // Set up the reference.
   text = GetComponent<Text>();
    
        
      

    }

    void Start()
    {
      
    }

    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
     text.text = "Volume: " + MenuScript.currentVolume;
    }
}
