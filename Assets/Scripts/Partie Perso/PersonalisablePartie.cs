using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PersonalisablePartie : MonoBehaviour {

    public static float nombrescore;


    Text text;

    void Awake ()
    {
        text = GetComponent<Text>();
        nombrescore = 20;
    }

    
	// Use this for initialization
	void Start () {

   
     
	}
	
	// Update is called once per frame
	void Update () {

        text.text = "Score à atteindre: " + nombrescore;
       
	}


    public void OnToggleMot(bool selected)
    {

       
       
        if (selected == true)
        {
            GenerateurDeGenerateur.choixMota = true;
            
        }
        else
        {
            GenerateurDeGenerateur.choixMota = false;
        }
                   
        
    }


    public void OnToggleLettre(bool selected)
    {
      


        if (selected == true)
        {
            GenerateurDeGenerateur.choixLettrea = true;

        }
        else
        {
            GenerateurDeGenerateur.choixLettrea = false;
        }

        
    }


    public void choixMot(string choix)
    {
        Mot.liste = choix;
        Debug.Log(choix);
               
    }

    public void choixLettre(string choix)
    {
        Mot.liste = choix;
        Debug.Log(choix);

    }


    public void OnToggleMotChoix(bool choivre)
    {
         if (choivre == true)
        {
            GenerateurDeGenerateur.choixMotchoisia = true;
            
        }
        else
        {
            GenerateurDeGenerateur.choixMotchoisia = false;
        }
                
    }

    public void OnToggleLettreChoix(bool ch)
    {
        if (ch == true)
        {
            GenerateurDeGenerateur.choixLettrechoisia = true;

        }
        else
        {
            GenerateurDeGenerateur.choixLettrechoisia = false;
        }
    }

    public void longeurPartie(float lon)
    {
        GenerateurFinDePartie.finDePartiePerso = lon;
        nombrescore = lon;
        Debug.Log(lon);
        
    }
}
