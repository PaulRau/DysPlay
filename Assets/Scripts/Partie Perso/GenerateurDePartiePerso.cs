using UnityEngine;
using System.Collections;

public class GenerateurDePartiePerso : MonoBehaviour {

    public static bool choixMota = false;
    public static bool choixLettrea = false;
    public static bool choixMotchoisia = false;
    public static bool choixLettrechoisia = false;
    private float vit;
    public GameObject choixMot;
    public GameObject choixLettre;
    public GameObject choixMotChoisi;
    public GameObject choixLettreChoisi;


    

    // Use this for initialization

    void Start()
    {

        // mot.GetComponent<LettreChoisie>().speed = new Vector2(0, PersonalisablePartie.vitesse);
        vit = PersonalisablePartie.vitesse;

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
                if (vit == 0)
                {
                    Instantiate(choixLettre, new Vector2(0, 0), Quaternion.identity);
                }
                else Instantiate(choixLettre);
             
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
                if (vit == 0)
                {
                    Instantiate(choixLettreChoisi, new Vector2(0, 0), Quaternion.identity);
                }else Instantiate(choixLettreChoisi);



            }
        }
     
    }
}
