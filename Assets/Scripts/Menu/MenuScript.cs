using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {


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


    

}
