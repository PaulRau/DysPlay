using UnityEngine;
using System.Collections;

public class NiveauUn : MonoBehaviour {

    private int rand;
    private int frand;

    public GameObject[] fond;
    public GameObject[] sol;
    public Sprite[] alphabet;
 
    public GameObject lettrePrefab;
    public GameObject lettre;
    public static bool success = false;

    public int scoreValue = 1;


    // Use this for initialization
    void Start () { 

        Instantiate(fond[rand]);
        Instantiate(sol[0]);
        frand = Random.Range(0, fond.Length);
       
    }
	
	// Update is called once per frame
	void Update () {

       

        if (GameObject.Find("LettreChoisie(Clone)") == null)
        {
            success = false;
            rand = Random.Range(0, alphabet.Length);

            lettre=Instantiate(lettrePrefab);
            lettre.GetComponent<LettreChoisie>().speed = new Vector2(0, 2.5f);

            lettre.GetComponent<SpriteRenderer>().sprite = alphabet[rand];
            lettre.GetComponent<SpriteRenderer>().color = Color.white;

        }

        if (success == false) { clavier(); }

    }

    

    

    void BonneLettre()
    {
            
            //Change la couleur de la lettre
            lettre.GetComponent<SpriteRenderer>().color = Color.green;

            //Stope le mouvement de la lettre
            lettre.GetComponent<LettreChoisie>().speed = new Vector2(0, 0);

            //Incremente le score
            ScoreManager.score += scoreValue;

            //Detruit la lettre dans un délai de 0.5 secondes
            Destroy(lettre, 0.5f);

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
                }
        }
}
