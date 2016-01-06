using UnityEngine;
using System.Collections;

public class Mot : MonoBehaviour {

    private string liste = "abztr";
    private int i = 0;
    public GameObject Clone;
    public GameObject letterPrefab;
    private GameObject[] letter = new GameObject[12];
    public Sprite[] alphabet;     // Contient tous les sprites (à compléter dans l'instructor)
    public int scoreValue = 1;
    private int type = 0;
    private int currenttype = 0;
    private char[] characters;
    private int x = 0;
    

    // Use this for initialization
    void Start () {

        characters = liste.ToCharArray();


        
        for (i = 0; i < liste.Length; i++)
        {
            AfficheLettre(characters[i]);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        clavier();

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
            }
        }
       else
        {
            for(i=0;i<liste.Length; i++)
            {
                Destroy(letter[i]);
                // Ne pas oublier de detruire le mot éventuellement
                Destroy(Clone);
            }
        }
    }


    void AfficheLettre(char charactere)
    {

        switch (charactere)
        {
            case 'a':

                type = 0;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3+3*i,8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
               
                break;
            case 'b':
                type = 1;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'c':
                type = 2;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'd':
                type = 3;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'e':
                type = 4;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'f':
                type = 5;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'g':
                type = 6;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'h':
                type = 7;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'i':
                type = 8;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'j':
                type = 9;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'k':
                type = 10;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'l':
                type = 11;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'm':
                type = 12;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'n':
                type = 13;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'o':
                type = 14;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'p':
                type = 15;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'q':
                type = 16;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'r':
                type = 17;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 's':
                type = 18;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 't':
                type = 19;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'u':
                type = 20;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'v':
                type = 21;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'w':
                type = 22;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'x':
                type = 23;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'y':
                type = 24;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
            case 'z':
                type = 25;
                letter[i] = (GameObject)Instantiate(letterPrefab, new Vector2(-3 + 3 * i, 8), Quaternion.identity);
                letter[i].GetComponent<SpriteRenderer>().sprite = alphabet[type];
                break;
        }


    }

    void ActionLettre()
    {
        //Destroy(letter[x]);
        ScoreManager.score += scoreValue;

        letter[x].GetComponent<SpriteRenderer>().color = Color.green;
        x++;

    }


    //Définie l'action à effectuer en cas d'appui sur le clavier

    void clavier()
    {

        switch (currenttype)
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

    
	
}
