using UnityEngine;
//using UnityEngine.Events;
//using UnityEngine.UI;


/// <summary>
/// Déplace l'objet
/// </summary>

public class LettreAleatoire : MonoBehaviour
{
    // 1 - Designer variables

    public int scoreValue = 1;
    public int scoreValue1 = 1;

    /// <summary>
    /// Vitesse de déplacement
    /// </summary>
    public Vector2 speed = new Vector2(0, 6);

   
    /// <summary>
    /// Direction
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);


    private Vector2 movement;

    // Instanciation des GameObject et des Sprites
    
    public GameObject letter;
    
    private int rand;
    public Sprite[] alphabet;     // Contient tous les sprites (à compléter dans l'instructor)
    public Vector2 newPos = new Vector2(0, 8);
    public static bool success = false;
    public static bool spec;   //Caractère spéciaux ou pas
    private bool caret;
    private int Ctype = 0;
    private bool activationCaret;

    void Start()
    {
        

        letter.GetComponent<LettreAleatoire>().speed = new Vector2(0, PersonalisablePartie.vitesse);
        success = false;      
       
        if (spec == true)
        {
            rand = Random.Range(0, alphabet.Length);                            //nombre aléatoire entre 0 et la taille de la liste Alphabet
        }
        else rand = Random.Range(0, 25);  // Les 25 premiers caractères correspondent aux lettres A à Z, sans caractères spéciaux.

        letter.GetComponent<SpriteRenderer>().sprite = alphabet[rand];      //ajoute le sprite correspondant à l'object lettre

        switch (rand) {

            case 30:
                Ctype = 0;
                break;
            case 31:
                Ctype = 1;
                break;
            case 32:
                Ctype = 2;
                break;
            case 33:
                Ctype = 3;
                break;
            case 34:
                Ctype = 4;
                break;
            case 35:
                Ctype = 5;
                break;
            case 36:
                Ctype = 6;
                break;
            case 37:
                Ctype = 7;
                break;
                
        }
        activationCaret = false;
    }

    void Update()
    {
        // mouvement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);

        // Récupère l'action sur le clavier
        

        if (success== false) { clavier(); }

        if (activationCaret == true) { CaracSpeciaux(); }


    }

    void FixedUpdate()
    {
        // Application du mouvement
        GetComponent<Rigidbody2D>().velocity = movement;
    }

 

    //Définie l'action à effectuer en cas d'appui sur la bonne lettre

    void BonneLettre()
    {
        caret = false;
        activationCaret = false;

        //Change la couleur de la lettre
        letter.GetComponent<SpriteRenderer>().color = Color.green;

        //Stope le mouvement de la lettre
        letter.GetComponent<LettreAleatoire>().speed = new Vector2(0, 0);

        //Incremente le score

        ScoreManager.score += scoreValue;
        ScoreManager.bonneLettre += scoreValue1;

        //Detruit la lettre dans un délai de 0.5 secondes
        Destroy(letter, 0.5f);

        //Empêche le joueur de faire quoi que ce soit pendant ce délai
        success = true;
    }   
    
    void MauvaiseLettre()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetMouseButtonDown(0)) { } else letter.GetComponent<SpriteRenderer>().color = Color.red;
            ScoreManager.mauvaiseLettre += scoreValue1;

        }
    }

    //Définie l'action à effectuer en cas d'appui sur le clavier

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
                        letter.GetComponent<SpriteRenderer>().color = Color.cyan;
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
                        letter.GetComponent<SpriteRenderer>().color = Color.cyan;
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
