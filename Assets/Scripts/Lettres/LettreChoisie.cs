using UnityEngine;


/// <summary>
/// Déplace l'objet
/// </summary>

public class LettreChoisie : MonoBehaviour
{
    // 1 - Designer variables

    //public int scoreValue = 1;

    /// <summary>
    /// Vitesse de déplacement
    /// </summary>
    public Vector2 speed = new Vector2(10, 10);


    /// <summary>
    /// Direction
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);


    private Vector2 movement;

    // Instanciation des GameObject et des Sprites

    public GameObject letter;
    public GameObject letterPrefab;
    public static int type;              //rand est ici amené à être modifié dans un autre script pour déterminer la lettre qui doit être affichée
   // public Sprite[] alphabet;     // Contient tous les sprites (à compléter dans l'instructor)
    public Vector2 newPos = new Vector2(0, 8);


    void Start()
    {
         // letter.GetComponent<SpriteRenderer>().sprite = alphabet[type];      //ajoute le sprite correspondant à l'object lettre
    }

    void Update()
    {
        // mouvement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);

        // Récupère l'action sur le clavier

        //clavier();
    }

    void FixedUpdate()
    {
        // Application du mouvement
        GetComponent<Rigidbody2D>().velocity = movement;
    }

/*

    //Définie l'action à effectuer en cas d'appui sur la bonne lettre

    void ActionLettre()
    {

        Destroy(letter);
        ScoreManager.score += scoreValue;

        // GetComponent<SpriteRenderer>().color = Color.green;

    }


    //Définie l'action à effectuer en cas d'appui sur le clavier

    void clavier()
    {

        switch (type)
        {
            case 0:
                if (Input.GetKeyDown("a"))
                {
                    ActionLettre();
                }
                break;
            case 1:
                if (Input.GetKeyDown("b"))
                {
                    ActionLettre();
                }
                break;
            case 2:
                if (Input.GetKeyDown("c"))
                {
                    ActionLettre();
                }
                break;
            case 3:
                if (Input.GetKeyDown("d"))
                {
                    ActionLettre();
                }
                break;
            case 4:
                if (Input.GetKeyDown("e"))
                {
                    ActionLettre();
                }
                break;
            case 5:
                if (Input.GetKeyDown("f"))
                {
                    ActionLettre();
                }
                break;
            case 6:
                if (Input.GetKeyDown("g"))
                {
                    ActionLettre();
                }
                break;
            case 7:
                if (Input.GetKeyDown("h"))
                {
                    ActionLettre();
                }
                break;
            case 8:
                if (Input.GetKeyDown("i"))
                {
                    ActionLettre();
                }
                break;
            case 9:
                if (Input.GetKeyDown("j"))
                {
                    ActionLettre();
                }
                break;
            case 10:
                if (Input.GetKeyDown("k"))
                {
                    ActionLettre();
                }
                break;
            case 11:
                if (Input.GetKeyDown("l"))
                {
                    ActionLettre();
                }
                break;
            case 12:
                if (Input.GetKeyDown("m"))
                {
                    ActionLettre();
                }
                break;
            case 13:
                if (Input.GetKeyDown("n"))
                {
                    ActionLettre();
                }
                break;
            case 14:
                if (Input.GetKeyDown("o"))
                {
                    ActionLettre();
                }
                break;
            case 15:
                if (Input.GetKeyDown("p"))
                {
                    ActionLettre();
                }
                break;
            case 16:
                if (Input.GetKeyDown("q"))
                {
                    ActionLettre();
                }
                break;
            case 17:
                if (Input.GetKeyDown("r"))
                {
                    ActionLettre();
                }
                break;
            case 18:
                if (Input.GetKeyDown("s"))
                {
                    ActionLettre();
                }
                break;
            case 19:
                if (Input.GetKeyDown("t"))
                {
                    ActionLettre();
                }
                break;
            case 20:
                if (Input.GetKeyDown("u"))
                {
                    ActionLettre();
                }
                break;
            case 21:
                if (Input.GetKeyDown("v"))
                {
                    ActionLettre();
                }
                break;
            case 22:
                if (Input.GetKeyDown("w"))
                {
                    ActionLettre();
                }
                break;
            case 23:
                if (Input.GetKeyDown("x"))
                {
                    ActionLettre();
                }
                break;
            case 24:
                if (Input.GetKeyDown("y"))
                {
                    ActionLettre();
                }
                break;
            case 25:
                if (Input.GetKeyDown("z"))
                {
                    ActionLettre();
                }
                break;

        }
    }
*/

}

