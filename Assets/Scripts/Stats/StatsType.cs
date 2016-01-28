using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatsType : MonoBehaviour {

    Text textScoreStatType;
    string text = System.IO.File.ReadAllText(Application.persistentDataPath + "/Type.txt");



    // Use this for initialization
    void Start()
    {
        textScoreStatType = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {


        textScoreStatType.text = text + "";

    }
}