using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinDePartie2 : MonoBehaviour
{



   // Text text;
    // Text text1;
     Text text2;


    void Awake()
    {
        // Set up the reference.
        //text = GetComponent<Text>();

        // Set up the reference.
         text2 = GetComponent<Text>();

        // Set up the reference.
        //  text1 = GetComponent<Text>();


    }


    void Start()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
      //  text.text = "Score: " + ScoreManager.score;
        // text1.text = "Nombres de bonnes lettres : " + ScoreManager.bonneLettre;
        text2.text = "Nombre de mauvaises lettres: " + ScoreManager.mauvaiseLettre;



    }
}
