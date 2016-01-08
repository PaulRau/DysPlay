using UnityEngine;
using System.Collections;

public class PersonalisablePartie : MonoBehaviour {

    


    
	// Use this for initialization
	void Start () {

   
     
	}
	
	// Update is called once per frame
	void Update () {
       
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
}
