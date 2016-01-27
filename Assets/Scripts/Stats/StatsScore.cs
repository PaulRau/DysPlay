using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsScore : MonoBehaviour {

    Text textScoreStat;

    string text = System.IO.File.ReadAllText(@"C:\Users\Paul\Documents\DysPlay\Stats\Score.txt");



	// Use this for initialization
	void Start () {
        textScoreStat = GetComponent<Text>();
       
	}
	
	// Update is called once per frame
	void Update () {

        
        textScoreStat.text = "" + text;
        
	}
}
