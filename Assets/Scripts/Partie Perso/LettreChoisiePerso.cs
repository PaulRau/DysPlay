using UnityEngine;
using System.Collections;

public class LettreChoisiePerso : MonoBehaviour {



    //public GameObject choixLettreChoisiPrefab;
    private char[] charactere;
    private int rand;
    public static string cara;

    // utiles pour les caractères spéciaux
    private bool caret;
    private int Ctype;
    private bool activationCaret;

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
        activationCaret = false;
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
            case 'é':
                type = 26;


                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'è':
                type = 27;


                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'à':
                type = 28;


                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ç':
                type = 29;


                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'ê':
                type = 30;
                Ctype = 0;

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'â':
                type = 31;
                Ctype = 1;

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                type = 30;
                break;
            case 'û':
                type = 32;
                Ctype = 2;

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                
                break;
            case 'î':
                type = 33;
                Ctype = 3;

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                
                break;
            case 'ô':
                type = 34;
                Ctype = 4;

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                
                break;
            case 'ë':
                type = 35;
                Ctype = 5;

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                
                break;
            case 'ü':
                type = 36;
                Ctype = 6;

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                
                break;
            case 'ï':
                type = 37;
                Ctype = 7;

                choixLettreChoisi.GetComponent<SpriteRenderer>().sprite = alphabet[type];
                
                break;

        }
        if (activationCaret== true) { CaracSpeciaux(); }

        if (success == false) { clavier(); }

	}


    void BonneLettre()
    {
        caret = false;
        activationCaret = false;
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
                        choixLettreChoisi.GetComponent<SpriteRenderer>().color = Color.cyan;
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
                        choixLettreChoisi.GetComponent<SpriteRenderer>().color = Color.cyan;
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
