using UnityEngine;
using System.Collections;

public class NiveauQuatre : MonoBehaviour
{

    private int rand;
    public static int frand;
    private bool activationCaret;
    private bool caret;


    public GameObject[] fond;
    public GameObject[] sol;
    public Sprite[] alphabet;

    public GameObject lettrePrefab;
    public GameObject lettre;
    public static bool success = false;

    public int scoreValue = 1;
    private int ctype;

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
        
        activationCaret = false;
        caret = false;

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

                activationCaret = false;
                success = false;
                rand = Random.Range(0, alphabet.Length);

                lettre = Instantiate(lettrePrefab);
                lettre.GetComponent<LettreNiveau>().speed = new Vector2(0, 7);

                lettre.GetComponent<SpriteRenderer>().sprite = alphabet[rand];
                lettre.GetComponent<SpriteRenderer>().color = Color.white;

                switch (rand)
                {
                    case (9):
                        ctype = 0;
                        break;
                    case (10):
                        ctype = 1;
                        break;
                    case (11):
                        ctype = 2;
                        break;
                    case (12):
                        ctype = 3;
                        break;
                    case (13):
                        ctype = 4;
                        break;
                    case (14):
                        ctype = 5;
                        break;
                    case (15):
                        ctype = 6;
                        break;
                    case (16):
                        ctype = 7;
                        break;
                }

            }


            if (activationCaret == true) { CaracSpeciaux(); }

            if (success == false) { clavier(); }



        }
    }





    void BonneLettre()
    {
        if (Combo.combo < 5)
        {
            Combo.combo++;
        }

        caret = false;
        activationCaret = false;

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
                if (Input.GetKeyDown("a"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 1:
                if (Input.GetKeyDown("e"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 2:
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 3:
                if (Input.GetKeyDown("o"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 4:
                if (Input.GetKeyDown("u"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 5:
                if (Input.GetKeyDown("0"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 6:
                if (Input.GetKeyDown("2"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 7:
                if (Input.GetKeyDown("7"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 8:
                if (Input.GetKeyDown("9"))
                {
                    BonneLettre();
                }
                else MauvaiseLettre();
                break;
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
                if (caret == false)
                {
                    if (Input.GetKeyDown(KeyCode.RightBracket) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
                    {
                        activationCaret = true;
                        lettre.GetComponent<SpriteRenderer>().color = Color.cyan;
                        caret = true;
                    }
                    else MauvaiseLettre();
                }
                break;
            case 14:
            case 15:
            case 16:
                if (caret == false)
                {
                    if (Input.GetKeyDown(KeyCode.RightBracket) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
                    {
                        activationCaret = true;
                        lettre.GetComponent<SpriteRenderer>().color = Color.cyan;
                        caret = true;
                    }
                    else if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) { } else MauvaiseLettre();
                }

                break;

        }
    }

    void CaracSpeciaux()
    {

        switch (ctype)
        {
            case 0:
                if (Input.GetKeyDown("a"))
                {
                    BonneLettre();
                }


                break;
            case 1:
                if (Input.GetKeyDown("e"))
                {
                    BonneLettre();
                }

                break;
            case 2:
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }

                break;
            case 3:
                if (Input.GetKeyDown("o"))
                {
                    BonneLettre();
                }

                break;
            case 4:
                if (Input.GetKeyDown("u"))
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
                if (Input.GetKeyDown("i"))
                {
                    BonneLettre();
                }

                break;
            case 7:
                if (Input.GetKeyDown("u"))
                {
                    BonneLettre();
                }

                break;
        }
    }
}
