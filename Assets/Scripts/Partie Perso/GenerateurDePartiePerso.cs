﻿using UnityEngine;
using System.Collections;

public class GenerateurDePartiePerso : MonoBehaviour {

    public static bool choixMota = false;
    public static bool choixLettrea = false;
    public static bool choixMotchoisia = false;
    public static bool choixLettrechoisia = false;
    private float vit;
    public GameObject choixMot;
    public GameObject choixLettre;
    public GameObject choixMotChoisi;
    public GameObject choixLettreChoisi;
    
    public GameObject[] fond;
    public GameObject[] sol;
    
    private int rand;
   
    

    // Use this for initialization

    void Start()
    {
        rand = Random.Range(0, fond.Length);

        // mot.GetComponent<LettreChoisie>().speed = new Vector2(0, PersonalisablePartie.vitesse);
        vit = PersonalisablePartie.vitesse;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Paquerettes(Clone)") == null && GameObject.Find("Plage(Clone)") == null)
        {
            Instantiate(fond[rand]);
        }

        if (GameObject.Find("Sol Invisible(Clone)") == null)
        {
            Instantiate(sol[0]);
            
        }



        if (choixMota == true)
        {
            if (GameObject.Find("LettreChoisie(Clone)") == null)
            {
                Instantiate(choixMot);
            }       

        }

        if (choixLettrea == true)
        {
            if (GameObject.Find("LettreAleatoire(Clone)") == null)
            {
                if (vit == 0)
                {
                    Instantiate(choixLettre, new Vector2(0, 0), Quaternion.identity);
                }
                else Instantiate(choixLettre);
             
            } 
        }

        if (choixMotchoisia == true)
        {
            if (GameObject.Find("LettreChoisie(Clone)") == null)
            {
                Instantiate(choixMotChoisi);
            }
        }

        if (choixLettrechoisia == true)
        {
            if (GameObject.Find("LettreChoisiPerso(Clone)") == null)
            {
                if (vit == 0)
                {
                    Instantiate(choixLettreChoisi, new Vector2(0, 0), Quaternion.identity);
                }else Instantiate(choixLettreChoisi);



            }
        }
     
    }
}
