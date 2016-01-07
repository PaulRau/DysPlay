using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    bool pause = false;

    //retour menu
    public void retourMenu()
    {
        Application.LoadLevel("Menu");
        Time.timeScale = 1.0f;
        pause = false;
    }

    //menu
    public void butonQuitter()
    {
        Application.Quit();
    }

    public void butonJouerNiveaux()
    {
        Application.LoadLevel("Scene1.0.1");
    }

    public void butonJouerPerso()
    {
        Application.LoadLevel("Scene1.0.1");
    }


    public void butonOptions()
    {
        Application.LoadLevel("Options");
    }


    //scene1.0.1
    public void butonPause()
    {
        //pause
        if (pause == false)
        {
            Time.timeScale = 0.0f;
            pause = true;
        }
        else
        {
            Time.timeScale = 1.0f;
            pause = false;
        }
    }

   

}
