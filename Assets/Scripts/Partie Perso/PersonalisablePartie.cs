using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PersonalisablePartie : MonoBehaviour {

    public static float nombrescore;

    public static bool OuiNonVie = true;

    public static bool bloc = false;
    public static bool bloc1 = false;
    public static bool bloc2 = false;
    public static bool bloc3 = false;

    public static float NbLettreAlea;
    public static float vitesse = 4;

    public static bool caracspec;

   public GameObject but;
   public GameObject but2;
   public GameObject but3;
   public GameObject but4;
   public GameObject but5;
   public GameObject but6;
   public GameObject but7;


    public Text text;
    
    

    void Awake ()
    {
        text = GetComponent<Text>();

    
        nombrescore = 20;
        bloc = false;
        bloc1 = false;
        bloc2 = false;
     
    }

    
	// Use this for initialization
	void Start () {

        OuiNonVie = true;
        vitesse = 4;


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
        but6.GetComponent<Toggle>().isOn = false;
        but7.GetComponent<Toggle>().isOn = false;
        but4.GetComponent<Toggle>().isOn = false;
        but3.GetComponent<Toggle>().isOn = false;
       
    }

    public void LETTREtoggle(bool sela)
    {
        bloc1 = sela;
        but.GetComponent<Toggle>().isOn = false;
        but2.GetComponent<Toggle>().isOn = false;
        but5.GetComponent<Toggle>().isOn = false;
        
    }

    public void OnToggleMot(bool selected)
    {

        bloc2 = selected;
           if(bloc == true)
           {
               if (selected == true)
               {
                   GenerateurDePartiePerso.choixMota = true;

               }
               else
               {
                   GenerateurDePartiePerso.choixMota = false;
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
       
    }

    public void OnToggleLettre(bool selected)
    {
      

         if(bloc1 == true)
           {
        if (selected == true)
        {
            GenerateurDePartiePerso.choixLettrea = true;

        }
        else
        {
            GenerateurDePartiePerso.choixLettrea = false;
        }
           }
         else
         {
             but3.GetComponent<Toggle>().isOn = false;
         }

        
    }


    public void choixMot(string choix)
    {
        Mot.liste = choix; // a supprimer
        MotChoisiePerso.listeChoisi = choix;


        
               
    }

    public void choixLettre(string choix)
    {
       // Mot.liste = choix;

        LettreChoisiePerso.cara = choix;

    }


    public void OnToggleMotChoix(bool choivre)
    {

        if(bloc == true)
           {
         if (choivre == true)
        {
            GenerateurDePartiePerso.choixMotchoisia = true;
            
        }
        else
        {
            GenerateurDePartiePerso.choixMotchoisia = false;
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
            GenerateurDePartiePerso.choixLettrechoisia = true;
            but6.GetComponent<Toggle>().isOn = false;
            but7.GetComponent<Toggle>().isOn = false;

        }
        else
        {
            GenerateurDePartiePerso.choixLettrechoisia = false;
        }
           }
         else
         {
             but4.GetComponent<Toggle>().isOn = false;
         }
    }
     
    public void OnToggleCarSpecLettre (bool spec)
    {

        if (bloc1 == true)
        {
            if (spec == true)
            {
                but4.GetComponent<Toggle>().isOn = false;
                LettreAleatoire.spec = true;
            }
            else LettreAleatoire.spec = false;
        }
        else but7.GetComponent<Toggle>().isOn = false;
     
    }

    public void longeurPartie(float lon)
    {
        GenerateurFinDePartie.finDePartiePerso = lon;
        nombrescore = lon;
       
        
    }

    public void OnToggleCarSpecMot(bool spec)
    {
        if(bloc2==true)
        {
            if (spec == true)
            {
                MotAleaPerso.spec = true;
            }
            else MotAleaPerso.spec = false;
        }
        else
        {
            but5.GetComponent<Toggle>().isOn = false;
        } 

        }

    public void OnToggleTRUEspec(bool truespec)
    {

        if(bloc1 == true)
        {

            if(truespec == true)
            {
                but4.GetComponent<Toggle>().isOn = false;
                caracspec = truespec;
            }
        


        }
        else but6.GetComponent<Toggle>().isOn = false;


    }
      
    }
