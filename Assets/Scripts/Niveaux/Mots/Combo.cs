using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Combo : MonoBehaviour
{
    public static int combo;    
   


    Text text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        if (combo == 5) { text.text = "Combo !"; } else text.text = "";
    }
}
