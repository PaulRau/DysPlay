using UnityEngine;
using System.Collections;

public class GenerateurDePartiePerso : MonoBehaviour {

    public static bool choixMota = false;
    public static bool choixLettrea = false;
    public static bool choixMotchoisia = false;
    public static bool choixLettrechoisia = false;
    public GameObject choixMot;
    public GameObject choixLettre;
    public GameObject choixMotChoisi;
    public GameObject choixLettreChoisi;


    

    // Use this for initialization

    void Start()
    {
    
       // mot.GetComponent<LettreChoisie>().speed = new Vector2(0, PersonalisablePartie.vitesse);


    }

    // Update is called once per frame
    void Update()
    {
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
                Instantiate(choixLettre);
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

                Instantiate(choixLettreChoisi);

            }
        }
     
    }
}
