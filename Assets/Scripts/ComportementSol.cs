﻿using UnityEngine;
using System.Collections;

public class ComportementSol : MonoBehaviour {

    
    public int scoreValue = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LettreChoisie(Clone)" || collision.gameObject.name == "LettreAleatoire(Clone)" || collision.gameObject.name == "Mot(Clone)" || collision.gameObject.name == "MotAleatoire(Clone)")
        {
            //detruit la lettre
            Destroy(collision.gameObject);
            
            ScoreManager.score -= scoreValue;
            if (ScoreManager.score < 0) ScoreManager.score = 0;
        }


    }
}
