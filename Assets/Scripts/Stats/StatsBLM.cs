using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using System.IO;
using System.Text;
using System;

public class StatsBLM : MonoBehaviour {

    Text textScoreStatBLM;
    string text = System.IO.File.ReadAllText(Application.persistentDataPath + "/BLM.txt");



    // Use this for initialization
    void Start()
    {
       
        textScoreStatBLM = GetComponent<Text>();
        text = Application.dataPath + "/BLM.txt";
    }

    // Update is called once per frame
    void Update()
    {


        textScoreStatBLM.text = "" + text;

    }
}