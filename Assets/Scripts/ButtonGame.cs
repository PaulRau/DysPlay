using UnityEngine;
using System.Collections;

public class ButtonGame : MonoBehaviour {

    void OnGUI()
    {
        const int buttonWidth = 70;
        const int buttonHeight = 50;

        Rect buttonRect = new Rect(
             Screen.width / 2 - (buttonWidth / 2)+230,
             (2 * Screen.height / 3) - (buttonHeight / 2) + 140,
             buttonWidth,
             buttonHeight
             );

        if (GUI.Button(buttonRect, "RETOUR"))
        {
            Application.LoadLevel("Menu");
        }

    }



}
