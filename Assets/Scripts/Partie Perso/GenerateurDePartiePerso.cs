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
    
    public GameObject[] fond;
    public GameObject[] sol;
    
    private int rand;

   
   public static bool statPartiePerso = true;
   
    

    // Use this for initialization

    void Start()
    {
        Time.timeScale = 1.0f;

        NiveauUn.frand = 0; NiveauDeux.frand = 0; NiveauTrois.frand = 0; NiveauQuatre.frand = 0;
        GenerateurFinDePartie.But = 50000;
        rand = Random.Range(0, fond.Length);

        // mot.GetComponent<LettreChoisie>().speed = new Vector2(0, PersonalisablePartie.vitesse);
        vit = PersonalisablePartie.vitesse;

    }

    // Update is called once per frame
    void Update()
    {

      
            if (GameObject.Find("Paquerettes(Clone)") == null && GameObject.Find("Sport(Clone)") == null && GameObject.Find("Jungle(Clone)") == null && GameObject.Find("Plage(Clone)") == null)
            {
                Instantiate(fond[rand]);
              
                statPartiePerso = true;
                
            }

            if (GameObject.Find("Sol Invisible(Clone)") == null)
            {
                Instantiate(sol[0]);

         
        }

        if (Compteur.timeRemaining < 0.01f)
        {
            if (choixMota == true)
            {
                if (GameObject.Find("LettreChoisie(Clone)") == null)
                {
                    //compteurNbPartie++;
                   // Debug.Log(compteurNbPartie);
                    Instantiate(choixMot);
                }

            }
        }


        if (Compteur.timeRemaining < 0.01f)
        {
            if (choixLettrea == true || LettreAleatoire.spec == true || PersonalisablePartie.caracspec == true)
            {
                if (GameObject.Find("LettreAleatoire(Clone)") == null)
                {
                    if (vit == 0)
                    {
                        
                        Instantiate(choixLettre, new Vector2(0, 0), Quaternion.identity);
                    }
                    else
                    {
                        
                        Instantiate(choixLettre);
                    }

                }
            }
        }

        if (Compteur.timeRemaining < 0.01f)
        {
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
                      ;
                        Instantiate(choixLettreChoisi, new Vector2(0, 0), Quaternion.identity);
                    }
                    else
                    {
                        
                        Instantiate(choixLettreChoisi);
                    }



                }
            }
        }
    }
}
