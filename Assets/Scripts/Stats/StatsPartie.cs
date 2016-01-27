using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsPartie : MonoBehaviour {

    Text textScoreStatBLM;
    string text = System.IO.File.ReadAllText(@"C:\Users\Paul\Documents\DysPlay\Stats\Partie.txt");



    // Use this for initialization
    void Start()
    {
        textScoreStatBLM = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {


        textScoreStatBLM.text = "" + text;

    }
}