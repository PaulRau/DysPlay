﻿using UnityEngine;
using System.Collections;

public class Mot : MonoBehaviour {

    public static string liste;

    private string[] newliste; 
    
    private int i = 0;
    private int j = 0;
    public GameObject Clone;
    public GameObject letterPrefab;
    private GameObject[] letter = new GameObject[12];
    public Sprite[] alphabet;     // Contient tous les sprites (à compléter dans l'instructor)
    public int scoreValue = 1;
    public int scoreValue1 = 1;
    private int type = 0;
    private int currenttype = 0;
    private char[] characters;
    private int x = 0;
    public static bool success = false;
    private float vit;

    // utiles pour les caractères spéciaux
    private bool caret;
    private int Ctype;
    private bool activationCaret;


    // Use this for initialization
    void Start () {

        activationCaret = false;

        vit = PersonalisablePartie.vitesse;

        Clone.GetComponent<LettreChoisie>().speed = new Vector2(0, PersonalisablePartie.vitesse);
        success = false;

        for (j = 0; j < 12; j++)
        {
            letter[j] = null;           //Initialise le tableau de lettre

        }


       newliste= liste.Split(',');

       for (int k = 0; k < 6; k++)
       {
           Debug.Log(newliste[k]);
       }
           
        characters = liste.ToCharArray();
        Debug.Log(liste);

        
        for (i = 0; i < liste.Length; i++)
        {
            AfficheLettre(characters[i]);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        

        if (x < liste.Length)
        {
            switch (characters[x])
            {
                case 'a':

                    currenttype = 0;

                    break;
                case 'b':
                    currenttype = 1;
                    break;
                case 'c':
                    currenttype = 2;
                    break;
                case 'd':
                    currenttype = 3;
                    break;
                case 'e':
                    currenttype = 4;
                    break;
                case 'f':
                    currenttype = 5;
                    break;
                case 'g':
                    currenttype = 6;
                    break;
                case 'h':
                    currenttype = 7;
                    break;
                case 'i':
                    currenttype = 8;
                    break;
                case 'j':
                    currenttype = 9;
                    break;
                case 'k':
                    currenttype = 10;
                    break;
                case 'l':
                    currenttype = 11;
                    break;
                case 'm':
                    currenttype = 12;
                    break;
                case 'n':
                    currenttype = 13;
                    break;
                case 'o':
                    currenttype = 14;
                    break;
                case 'p':
                    currenttype = 15;
                    break;
                case 'q':
                    currenttype = 16;
                    break;
                case 'r':
                    currenttype = 17;
                    break;
                case 's':
                    currenttype = 18;
                    break;
                case 't':
                    currenttype = 19;
                    break;
                case 'u':
                    currenttype = 20;
                    break;
                case 'v':
                    currenttype = 21;
                    break;
                case 'w':
                    currenttype = 22;
                    break;
                case 'x':
                    currenttype = 23;
                    break;
                case 'y':
                    currenttype = 24;
                    break;
                case 'z':
                    currenttype = 25;
                    break;
                case 'é':
                    currenttype = 26;
                    break;
                case 'è':
                    currenttype = 27;
                    break;
                case 'à':
                    currenttype = 28;
                    break;
                case 'ç':
                    currenttype = 29;
                    break;
                case 'ê':
                    currenttype = 30;
                    Ctype = 0;     
                    break;
                case 'â':
                    currenttype = 31;
                    Ctype = 1;
                    break;
                case 'û':
                    currenttype = 32;
                    Ctype = 2;
                    break;
                case 'î':
                    currenttype = 33;
                    Ctype = 3;
                    break;
                case 'ô':
                    currenttype = 34;
                    Ctype = 4;
                    break;
                case 'ë':
                    currenttype = 35;
                    Ctype = 5;
                    break;
                case 'ü':
                    currenttype = 36;
                    Ctype = 6;
                    break;
                case 'ï':
                    currenttype = 37;
                    Ctype = 7;
                    break;
            }
        }
       else
        {

            success = true;
           for (i = 0; i < liste.Length; i++)
           {
                
                // Arrête le mouvement de chaque lettre 
              letter[i].GetComponent<LettreChoisie>().speed = new Vector2(0,0);
                
                // Detruit chaque lettre après un délai de 0.5 secondes
                Destroy(letter[i],0.5f); 
                   
           }
            // Ne pas oublier de detruire l'object mot éventuellement
            Destroy(Clone,0.5f);
        }
        

        if (success== false) { clavier(); }

        if (activationCaret == true) { CaracSpeciaux(); }

    }


    void AfficheLettre(char charactere)
    {

        switch (charactere)
        {
            case 'a':

                type = 0;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'b':
                type = 1;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'c':
                type = 2;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'd':
                type = 3;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'e':
                type = 4;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'f':
                type = 5;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'g':
                type = 6;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'h':
                type = 7;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'i':
                type = 8;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'j':
                type = 9;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'k':
                type = 10;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'l':
                type = 11;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'm':
                type = 12;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'n':
                type = 13;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'o':
                type = 14;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'p':
                type = 15;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'q':
                type = 16;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'r':
                type = 17;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 's':
                type = 18;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 't':
                type = 19;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'u':
                type = 20;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'v':
                type = 21;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'w':
                type = 22;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'x':
                type = 23;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'y':
                type = 24;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'z':
                type = 25;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'é':
                type = 26;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'è':
                type = 27;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'à':
                type = 28;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            
            case 'ç':
                type = 29;
                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ê':

                type = 30;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'â':

                type = 31;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'û':

                type = 32;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'î':

                type = 33;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ô':

                type = 34;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ë':

                type = 35;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ü':

                type = 36;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ï':

                type = 37;

                if (vit == 0)
                {

                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 0), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 0), Quaternion.identity);
                }
                else
                {
                    if (liste.Length < 6)
                    {
                        letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste.Length + 3 * i + 1.5f, 8), Quaternion.identity);
                    }
                    else letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1f) * liste.Length + 2 * i + 1f, 8), Quaternion.identity);
                }

                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;


        }
        if (liste.Length > 5)
        {
            letter[i].GetComponent<Transform>().localScale = new Vector2(0.3f, 0.3f);

        }

        if (liste.Length > 9)
        {
            letter[i].GetComponent<Transform>().localScale = new Vector2(0.25f, 0.25f);

        }


    }


    void BonneLettre()
    {
        caret = false;
        activationCaret = false;

        ScoreManager.score += scoreValue;
        ScoreManager.bonneLettre += scoreValue1;

        letter[x].GetComponent<SpriteRenderer>().color = Color.green;
        x++;

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
                letter[x].GetComponent<SpriteRenderer>().color = Color.red;
                ScoreManager.mauvaiseLettre += scoreValue1;
            }
        }
    }


    //Définie l'action à effectuer en cas d'appui sur le clavier

    void clavier()
    {

        switch (currenttype)
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
            case 26:
                if (Input.GetKeyDown("2"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 27:
                if (Input.GetKeyDown("7"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 28:
                if (Input.GetKeyDown("0"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            
                
            case 29:
                if (Input.GetKeyDown("9"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;

            case 30:
            case 31:
            case 32:
            case 33:
            case 34:
                if (caret == false)
                {
                    if (Input.GetKeyDown(KeyCode.RightBracket) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
                    {
                        activationCaret = true;
                        letter[x].GetComponent<SpriteRenderer>().color = Color.cyan;
                        caret = true;
                    }
                    else MauvaiseLettre();
                }

                break;
            case 35:
            case 36:
            case 37:
                if (caret == false)
                {
                    if (Input.GetKeyDown(KeyCode.RightBracket) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
                    {
                        activationCaret = true;
                        letter[x].GetComponent<SpriteRenderer>().color = Color.cyan;
                        caret = true;
                    }
                    else if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) { } else MauvaiseLettre();
                }

                break;

        }
    }

    void CaracSpeciaux()
    {

        switch (Ctype)
        {
            case 0:
                if (Input.GetKeyDown("e"))
                {
                    BonneLettre();
                }


                break;
            case 1:
                if (Input.GetKeyDown("a"))
                {
                    BonneLettre();
                }

                break;
            case 2:
                if (Input.GetKeyDown("u"))
                {
                    BonneLettre();
                }

                break;
            case 3:
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }

                break;
            case 4:
                if (Input.GetKeyDown("o"))
                {
                    BonneLettre();
                }

                break;
            case 5:
                if (Input.GetKeyDown("e"))
                {
                    BonneLettre();
                }

                break;
            case 6:
                if (Input.GetKeyDown("u"))
                {
                    BonneLettre();
                }

                break;
            case 7:
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }

                break;
        }
    }



}
