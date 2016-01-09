using UnityEngine;
using System.Collections;

public class LettrechoixPerso : MonoBehaviour {

    public int scoreValue = 1;

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

    void Start()
    {
        success = false;
        rand = Random.Range(0, alphabet.Length);                            //nombre aléatoire entre 0 et 27
        letter.GetComponent<SpriteRenderer>().sprite = alphabet[rand];      //ajoute le sprite correspondant à l'object lettre
    }

    void Update()
    {
        // mouvement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);

        // Récupère l'action sur le clavier
        if (success == false) { clavier(); }

    }

    void FixedUpdate()
    {
        // Application du mouvement
        GetComponent<Rigidbody2D>().velocity = movement;
    }

    public void setSpeed(int value)
    {


        speed = new Vector2(0, value);
    }

    //Définie l'action à effectuer en cas d'appui sur la bonne lettre

    void BonneLettre()
    {
        //Change la couleur de la lettre
        letter.GetComponent<SpriteRenderer>().color = Color.green;

        //Stope le mouvement de la lettre
        letter.GetComponent<LettreAleatoire>().speed = new Vector2(0, 0);

        //Incremente le score
        ScoreManager.score += scoreValue;

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

        }
    }

}
