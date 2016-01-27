using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsRatio : MonoBehaviour {
    Text textScoreStatBLM;
    string text = System.IO.File.ReadAllText(@"C:\Users\Paul\Documents\DysPlay\Stats\Ratio.txt");



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