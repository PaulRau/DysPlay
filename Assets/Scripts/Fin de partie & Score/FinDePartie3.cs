using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinDePartie3 : MonoBehaviour
{


    Text apmCanvas;


    void Awake()
    {
         apmCanvas = GetComponent<Text>();
    }


    void Start()
    {
        apmCanvas.text = "Nombre de bonnes lettres tappées par minute : " + GenerateurFinDePartie.apm;
    }
}