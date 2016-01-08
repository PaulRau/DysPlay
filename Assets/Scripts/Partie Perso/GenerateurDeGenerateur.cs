using UnityEngine;
using System.Collections;

public class GenerateurDeGenerateur : MonoBehaviour {

    public static bool choixMota = false;
    public static bool choixLettrea = false;
    public static bool choixMotchoisia = false;
    public GameObject choixMot;
    public GameObject choixLettre;
    public GameObject choixMotChoisi;
    // Use this for initialization

    void Start()
    {



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
     
    }
}
