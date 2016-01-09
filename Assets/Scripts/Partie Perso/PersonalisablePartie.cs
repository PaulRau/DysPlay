using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PersonalisablePartie : MonoBehaviour {

    public static float nombrescore;

    public static bool OuiNonVie = true;

    public static bool bloc = false;
    public static bool bloc1 = false;

    public static float NbLettreAlea;
    public static float vitesse = 4;

   public GameObject but;
   public GameObject but2;
   public GameObject but3;
   public GameObject but4;


    public Text text;
    
    

    void Awake ()
    {
        text = GetComponent<Text>();

    
        nombrescore = 20;
        bloc = false;
        bloc1 = false;
     
    }

    
	// Use this for initialization
	void Start () {

   
     
	}
	
	// Update is called once per frame
	void Update () {

        text.text = "Score à atteindre: " + nombrescore;
      
       
	}
    
    
    public void sliderVitesse(float vit)
    {
        vitesse = vit;

    }
       

    public void MOTtoggle(bool sel)
    {
        bloc = sel;
       
    }

    public void LETTREtoggle(bool sela)
    {
        bloc1 = sela;
        
    }

    public void OnToggleMot(bool selected)
    {


           if(bloc == true)
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
           else
           {
               but.GetComponent<Toggle>().isOn = false;
           }       
      }


    public void sliderNbLettreAlea(float slide)
    {
        NbLettreAlea = slide;
        
           
    }

    public void OnToggleVie(bool vita)
    {
        OuiNonVie = vita;
        Debug.Log(OuiNonVie);
    }

    public void OnToggleLettre(bool selected)
    {
      

         if(bloc1 == true)
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
         else
         {
             but3.GetComponent<Toggle>().isOn = false;
         }

        
    }


    public void choixMot(string choix)
    {
        Mot.liste = choix;
        
               
    }

    public void choixLettre(string choix)
    {
       // Mot.liste = choix;
    

    }


    public void OnToggleMotChoix(bool choivre)
    {

        if(bloc == true)
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
        else
        {
            but2.GetComponent<Toggle>().isOn = false;
        } 
    }

    public void OnToggleLettreChoix(bool ch)
    {
       
         if(bloc1 == true)
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
         else
         {
             but4.GetComponent<Toggle>().isOn = false;
         }
    }

    public void longeurPartie(float lon)
    {
        GenerateurFinDePartie.finDePartiePerso = lon;
        nombrescore = lon;
        Debug.Log(lon);
        
    }

   
}
