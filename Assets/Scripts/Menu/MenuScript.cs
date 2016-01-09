using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    bool pause = false;

    //partie perso
    public void jouerPatirPerso()
    {
        Application.LoadLevel("PersonalisablePartie");
    }


    public void reJouer()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1.0f;
        pause = false;
     
    }

    //retour menu
    public void retourMenu()
    {
        Application.LoadLevel("Menu");
        Time.timeScale = 1.0f;
        pause = false;
        GenerateurDeGenerateur.choixMota = false;
        GenerateurDeGenerateur.choixLettrea = false;
        GenerateurDeGenerateur.choixMotchoisia = false;
        GenerateurDeGenerateur.choixLettrechoisia = false;
        GenerateurFinDePartie.finDePartiePerso = 20;
        PersonalisablePartie.NbLettreAlea = 1;
    }

 

    //menu
    public void butonQuitter()
    {
        Application.Quit();
    }

    public void butonJouerNiveaux()
    {
        Application.LoadLevel("PartieNiveaux");
    }

    public void butonJouerPerso()
    {
        Application.LoadLevel("PartiePerso");
    }


    public void butonOptions()
    {
        Application.LoadLevel("Options");
    }



    //lancer niveau
    public void lancerNiveau1()
    {
        Application.LoadLevel("Scene1.0.1");
        Time.timeScale = 1.0f;
        pause = false;
    }
    public void lancerNiveau2()
    {
        Application.LoadLevel("Lettre1");
    }
    public void lancerNiveau3()
    {
        Application.LoadLevel("Lettre2");
    }
    public void lancerNiveau4()
    {
        Application.LoadLevel("Lettre3");
    }
    public void lancerNiveau5()
    {
        Application.LoadLevel("Lettre4");
    }
    public void lancerNiveau6()
    {
        Application.LoadLevel("Lettre5");
    }
    public void lancerNiveau7()
    {
        Application.LoadLevel("Mot1");
    }
    public void lancerNiveau8()
    {
        Application.LoadLevel("Mot2");
    }
    public void lancerNiveau9()
    {
        Application.LoadLevel("Mot3");
    }
    public void lancerNiveau10()
    {
        Application.LoadLevel("Mot4");
    }
   
    //scene1.0.1
    public void butonPause()
    {
        //pause
        if (pause == false)
        {
            MotAleatoire.success = true;
            LettreAleatoire.success = true;   //Empêche de faire des actions au clavier pendant la pause
            LettrechoisiPerso.success = true;

            Time.timeScale = 0.0f;
            pause = true;
        }
        else
        {
            MotAleatoire.success = false;
            LettreAleatoire.success = false;
            LettrechoisiPerso.success = false;

            Time.timeScale = 1.0f;
            pause = false;
        }
    }

  

}
