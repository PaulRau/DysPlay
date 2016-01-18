using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

    bool pause = false;

    public static float currentVolume = 0;

    

    public void volumeSlider(float vo)
    {
        currentVolume = vo;
        Debug.Log(currentVolume);
    }

    //partie perso
    public void jouerPatirPerso()
    {
        Application.LoadLevel("PersonalisablePartie");
    }


    public void allerNiveauxLettre()
    {
        Application.LoadLevel("PartieNiveauxLettre");
    }

    public void allerNiveauxMot()
    {
        Application.LoadLevel("PartieNiveauxMot");
    }

    public void reJouer()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1.0f;
        pause = false;
        Compteur.timeRemaining = 4;
     
    }

    //retour menu
    public void retourMenu()
    {
        Application.LoadLevel("Menu");
        Time.timeScale = 1.0f;
        pause = false;
        GenerateurDePartiePerso.choixMota = false;
        GenerateurDePartiePerso.choixLettrea = false;
        GenerateurDePartiePerso.choixMotchoisia = false;
        GenerateurDePartiePerso.choixLettrechoisia = false;
        GenerateurFinDePartie.finDePartiePerso = 20;
        PersonalisablePartie.NbLettreAlea = 1;
        Compteur.timeRemaining = 4;
    }
    

    public void retourMenuNiveaux()
    {
        Application.LoadLevel("PartieNiveaux");
        
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
        Application.LoadLevel("Lettre1Pool8");
        Time.timeScale = 1;
        pause = false;
    }
    public void lancerNiveau2()
    {
        Application.LoadLevel("Lettre2Pool16");
    }
    public void lancerNiveau3()
    {
        Application.LoadLevel("Lettre3Pool26");
    }
    public void lancerNiveau4()
    {
        Application.LoadLevel("Lettre4PoolAccent");
    }

   
    //scene1.0.1
    public void butonPause()
    {
        //pause
        if (pause == false)
        {
            MotAleatoire.success = true;
            LettreAleatoire.success = true;   //Empêche de faire des actions au clavier pendant la pause
            LettreChoisiePerso.success = true;
            MotAleaPerso.success = true;
            Mot.success = true;
            NiveauUn.success = true;
            NiveauDeux.success = true;
            NiveauTrois.success = true;
            NiveauQuatre.success = true;

            Time.timeScale = 0.0f;
            pause = true;
        }
        else
        {
            MotAleatoire.success = false;
            LettreAleatoire.success = false;
            LettreChoisiePerso.success = false;
            MotAleaPerso.success = false;
            Mot.success = false;
            NiveauUn.success = false;
            NiveauDeux.success = false;
            NiveauTrois.success = false;
            NiveauQuatre.success = false;

            Time.timeScale = 1.0f;
            pause = false;
        }
    }

  

}
