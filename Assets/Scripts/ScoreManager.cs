using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.
    public static int bonneLettre;
    public static int mauvaiseLettre;   


    Text text;                      // Reference to the Text component.
  

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        score = 0;

   
        // Reset the score.
       bonneLettre = 0;


        // Reset the score.
       mauvaiseLettre = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
    }
}