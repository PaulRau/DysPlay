using UnityEngine;
using System.Collections;

public class NiveauDeux : MonoBehaviour
{

    private int rand;
    public static int frand;

    

    public GameObject[] fond;
    public GameObject[] sol;
    public Sprite[] alphabet;

    public GameObject lettrePrefab;
    public GameObject lettre;
    public static bool success = false;

    public int scoreValue = 1;


    // Use this for initialization
    void Start()
    {
        GenerateurFinDePartie.finDePartiePerso = 500000;
        GenerateurFinDePartie.But = 20;
        LettresRestantes.lettresrestant = 20;
        Combo.combo = 0;
        GenerateurFinDePartie.MotsValide = 0;

        frand = Random.Range(0, fond.Length);
        GenerateurDePartiePerso.statPartiePerso = false;
        GenerateurDePartiePerso.compteurNbPartie++;
        Instantiate(fond[frand]);
        Instantiate(sol[0]);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Combo.combo == 5)
        {
            scoreValue = 2;
        }
        else scoreValue = 1;

        if (Compteur.timeRemaining < 0.01f)
        {
            if (GameObject.Find("LettreNiveau(Clone)") == null)
            {


                success = false;
                rand = Random.Range(0, alphabet.Length);

                lettre = Instantiate(lettrePrefab);
                lettre.GetComponent<LettreNiveau>().speed = new Vector2(0, 5);

                lettre.GetComponent<SpriteRenderer>().sprite = alphabet[rand];
                lettre.GetComponent<SpriteRenderer>().color = Color.white;

            }

            if (success == false) { clavier(); }

        }
    }





    void BonneLettre()
    {
        if (Combo.combo < 5)
        {
            Combo.combo++;
        }
        //Change la couleur de la lettre
        lettre.GetComponent<SpriteRenderer>().color = Color.green;

        //Stope le mouvement de la lettre
        lettre.GetComponent<LettreNiveau>().speed = new Vector2(0, 0);

        //Incremente le score
        ScoreManager.score += scoreValue;
        if (LettresRestantes.lettresrestant > 0) { LettresRestantes.lettresrestant--; }

        GenerateurFinDePartie.MotsValide++;

        //Detruit la lettre dans un délai de 0.5 secondes
        Destroy(lettre, 0.5f);
        
        NiveauDeux.success = true;

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
                Combo.combo = 0;
                lettre.GetComponent<SpriteRenderer>().color = Color.red;
                ScoreManager.mauvaiseLettre += scoreValue;
            }
        }
    }


    void clavier()
    {

        switch (rand)
        {
            case 0:
                if (Input.GetKeyDown("e"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 1:
                if (Input.GetKeyDown("a"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 2:
                if (Input.GetKeyDown("s"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 3:
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 4:
                if (Input.GetKeyDown("n"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 5:
                if (Input.GetKeyDown("t"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 6:
                if (Input.GetKeyDown("r"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 7:
                if (Input.GetKeyDown("l"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 8:
                if (Input.GetKeyDown("u"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 9:
                if (Input.GetKeyDown("o"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 10:
                if (Input.GetKeyDown("d"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 11:
                if (Input.GetKeyDown("c"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 12:
                if (Input.GetKeyDown("p"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 13:
                if (Input.GetKeyDown("m"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 14:
                if (Input.GetKeyDown("v"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 15:
                if (Input.GetKeyDown("q"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
           
        }
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
            Debug.Log("Detected key code: " + e.keyCode);

    }
}
