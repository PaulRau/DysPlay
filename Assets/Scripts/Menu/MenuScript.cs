using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    void OnGUI()
    {
        const int buttonWidth = 70;
        const int buttonHeight = 50;

        Rect buttonRect = new Rect(
            Screen.width / 2 - (buttonWidth / 2),
            (2 * Screen.height / 3) - (buttonHeight / 2) - 150,
            buttonWidth,
            buttonHeight
            );

        Rect buttonRect1 = new Rect(
           Screen.width / 2 - (buttonWidth / 2),
           (2 * Screen.height / 3) - (buttonHeight / 2) - 70,
           buttonWidth,
           buttonHeight
           );

        Rect buttonRect2 = new Rect(
           Screen.width / 2 - (buttonWidth / 2),
           (2 * Screen.height / 3) - (buttonHeight / 2)+10,
           buttonWidth,
           buttonHeight
           );

        if(GUI.Button(buttonRect, "JOUER"))
        {
            Application.LoadLevel("Scene1.0.1");
        }

        if (GUI.Button(buttonRect1, "OPTIONS"))
        {
            Application.LoadLevel("Options");
        }

        if (GUI.Button(buttonRect2, "QUITTER"))
        {
            Application.Quit();
        }

    }


}
