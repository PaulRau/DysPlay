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
        Compteur.timeForAPM = 0;
     
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

        PersonalisablePartie.caracspec = false;
        LettreAleatoire.spec = false;

        GenerateurFinDePartie.finDePartiePerso = 20;
        PersonalisablePartie.NbLettreAlea = 1;
        Compteur.timeRemaining = 4;
        Compteur.timeForAPM = 0;
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
    public void jungle1()
    {
        Application.LoadLevel("jungle1");
    }
    public void jungle2()
    {
        Application.LoadLevel("jungle2");
    }
    public void vacances1()
    {
        Application.LoadLevel("vacances1");
    }
    public void vacances2()
    {
        Application.LoadLevel("vacances2");
    }
    public void sport1()
    {
        Application.LoadLevel("sport1");
    }
    public void sport2()
    {
        Application.LoadLevel("sport2");
    }
    public void dessinanime1()
    {
        Application.LoadLevel("campagne1");
    }
    public void dessinanime2()
    {
        Application.LoadLevel("campagne2");
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
            Vacances1.success = true;
            Vacances2.success = true;
            Sport1.success = true;
            Sport2.success = true;
            Jungle1.success = true;
            Jungle2.success = true;
            Campagne1.success = true;
            Campagne2.success = true;

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
            Vacances1.success = false;
            Vacances2.success = false;
            Sport1.success = false;
            Sport2.success = false;
            Jungle1.success = false;
            Jungle2.success = false;
            Campagne1.success = false;
            Campagne2.success = false;

            Time.timeScale = 1.0f;
            pause = false;
        }
    }

  

}
