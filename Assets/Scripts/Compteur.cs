﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Compteur : MonoBehaviour {

  public static  float timeRemaining = 4;
   Text compteurDebut;
	// Use this for initialization
	void Awake () {

        compteurDebut = GetComponent<Text>();
        
	
	}
	
	// Update is called once per frame
	void Update () {

        if (timeRemaining >= 0)
        {
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);
        }
      
        


        if (timeRemaining > 0.01f)
        {
            compteurDebut.text = "" + (int)timeRemaining;
        }
        else
        {
            compteurDebut.text = "";
        }


	}
}
