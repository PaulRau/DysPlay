using UnityEngine;
using System.Collections;

public class MotAleatoire : MonoBehaviour
{

    public string[] liste;
    private int i = 0;
    private int j = 0;
    public GameObject Clone;
    public GameObject letterPrefab;
    private GameObject[] letter = new GameObject[12];
    public Sprite[] alphabet;     // Contient tous les sprites (à compléter dans l'instructor)
    public int scoreValue = 1;
    private int type = 0;
    private int currenttype = 0;
    private char[] characters;
    private int x = 0;
    private bool success = false;
    private int rand = 0;


    // Use this for initialization
    void Start()
    {
        rand = Random.Range(0, liste.Length);
        success = false;

        for (j = 0; j < 12; j++)
        {
            letter[j] = null;           //Initialise le tableau de lettre

        }

        characters = liste[rand].ToCharArray();



        for (i = 0; i < liste[rand].Length; i++)
        {
            AfficheLettre(characters[i]);

        }
    }
    // Update is called once per frame
    void Update()
    {


        if (x < liste[rand].Length)
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
            }
        }
        else
        {

            success = true;
            for (i = 0; i < liste[rand].Length; i++)
            {

                // Arrête le mouvement de chaque lettre 
                letter[i].GetComponent<LettreChoisie>().speed = new Vector2(0, 0);

                // Detruit chaque lettre après un délai de 0.5 secondes
                Destroy(letter[i], 0.5f);

            }
            // Ne pas oublier de detruire l'object mot éventuellement
            Destroy(Clone, 0.5f);
        }
        if (success == false) { clavier(); }

    }


    void AfficheLettre(char charactere)
    {

        switch (charactere)
        {
            case 'a':

                type = 0;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];

                break;
            case 'b':
                type = 1;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'c':
                type = 2;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'd':
                type = 3;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'e':
                type = 4;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'f':
                type = 5;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'g':
                type = 6;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'h':
                type = 7;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'i':
                type = 8;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'j':
                type = 9;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'k':
                type = 10;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'l':
                type = 11;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'm':
                type = 12;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'n':
                type = 13;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'o':
                type = 14;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'p':
                type = 15;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'q':
                type = 16;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'r':
                type = 17;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 's':
                type = 18;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 't':
                type = 19;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'u':
                type = 20;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'v':
                type = 21;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'w':
                type = 22;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'x':
                type = 23;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'y':
                type = 24;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'z':
                type = 25;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2((-1.5f) * liste[rand].Length + 3 * i + 1.5f, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
        }


    }


    void BonneLettre()
    {

        ScoreManager.score += scoreValue;

        letter[x].GetComponent<SpriteRenderer>().color = Color.green;
        x++;

    }

    void MauvaiseLettre()
    {
        if (Input.anyKeyDown)
        {
            letter[x].GetComponent<SpriteRenderer>().color = Color.red;
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

        }
    }



}
