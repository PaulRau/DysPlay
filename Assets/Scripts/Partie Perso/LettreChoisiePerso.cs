﻿using UnityEngine;
using System.Collections;

public class LettreChoisiePerso : MonoBehaviour {



    //public GameObject choixLettreChoisiPrefab;
    private char[] charactere;
    private int rand;
    public static string cara;

    public static bool success = false;

    public int scoreValue = 1;
    public int scoreValue1 = 1;

    public Sprite[] alphabet;
    private int type = 0;
    public GameObject choixLettreChoisi;

	// Use this for initialization
	void Start () {
        charactere = cara.ToCharArray();
        choixLettreChoisi.GetComponent<LettreChoisie>().speed = new Vector2(0, PersonalisablePartie.vitesse);
        success = false;
        rand = Random.Range(0, charactere.Length);
    }
	
	// Update is called once per frame
	void Update () {



        switch (charactere[rand])
        {
            case 'a':

                type = 0;
              

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'b':

                type = 1;

                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;

            case 'c':
                type = 2;
               

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
                case 'd':
                type = 3;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'e':
                type = 4;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'f':
                type = 5;
           

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'g':
                type = 6;
               

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'h':
                type = 7;
             

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'i':
                type = 8;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'j':
                type = 9;
              

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'k':
                type = 10;
               

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'l':
                type = 11;
            

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'm':
                type = 12;
               

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'n':
                type = 13;
            

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'o':
                type = 14;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'p':
                type = 15;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'q':
                type = 16;
            

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'r':
                type = 17;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 's':
                type = 18;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 't':
                type = 19;
               

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'u':
                type = 20;
              

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'v':
                type = 21;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'w':
                type = 22;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'x':
                type = 23;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'y':
                type = 24;
           

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'z':
                type = 25;
                

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break; 

        }

        if (success == false) { clavier(); }

	}


    void BonneLettre()
    {

        //Change la couleur de la lettre
        choixLettreChoisi.GetComponent<SpriteRenderer>().color = Color.green;

        //Stope le mouvement de la lettre
        choixLettreChoisi.GetComponent<LettreChoisie>().speed = new Vector2(0, 0);

        //Incremente le score
        ScoreManager.score += scoreValue;

        //Detruit la lettre dans un délai de 0.5 secondes
        Destroy(choixLettreChoisi, 0.5f);

        //Empêche le joueur de faire quoi que ce soit pendant ce délai
        success = true;

    }

    void MauvaiseLettre()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetMouseButtonDown(0))
            {

            }
            else
            {
                choixLettreChoisi.GetComponent<SpriteRenderer>().color = Color.red;
                ScoreManager.mauvaiseLettre += scoreValue1;
            }
        }
    }


    void clavier()
    {

        switch (type)
        {
            case 0:
                if (Input.GetKeyDown("a"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 1:
                if (Input.GetKeyDown("b"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 2:
                if (Input.GetKeyDown("c"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 3:
                if (Input.GetKeyDown("d"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 4:
                if (Input.GetKeyDown("e"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 5:
                if (Input.GetKeyDown("f"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 6:
                if (Input.GetKeyDown("g"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 7:
                if (Input.GetKeyDown("h"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 8:
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 9:
                if (Input.GetKeyDown("j"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 10:
                if (Input.GetKeyDown("k"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 11:
                if (Input.GetKeyDown("l"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 12:
                if (Input.GetKeyDown("m"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 13:
                if (Input.GetKeyDown("n"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 14:
                if (Input.GetKeyDown("o"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 15:
                if (Input.GetKeyDown("p"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 16:
                if (Input.GetKeyDown("q"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 17:
                if (Input.GetKeyDown("r"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 18:
                if (Input.GetKeyDown("s"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 19:
                if (Input.GetKeyDown("t"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 20:
                if (Input.GetKeyDown("u"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 21:
                if (Input.GetKeyDown("v"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 22:
                if (Input.GetKeyDown("w"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 23:
                if (Input.GetKeyDown("x"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 24:
                if (Input.GetKeyDown("y"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 25:
                if (Input.GetKeyDown("z"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;

        }
    }
}