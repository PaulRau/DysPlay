using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DureePartie : MonoBehaviour {

    Text duree;


    void Awake()
    {
        duree = GetComponent<Text>();
        
    }


    

    void Start()
    {
        Compteur.timeForAPM = Compteur.timeForAPM - 4;
        duree.text = "Durée de la partie : " + (int)Compteur.timeForAPM + " secondes";
    }
}
