using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateSliderNbLettre : MonoBehaviour {


    public Text text;
	// Use this for initialization

    void Awake()
    {
        
        text = GetComponent<Text>();
        PersonalisablePartie.NbLettreAlea = 2;
   

    }

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Nombre de lettres: " + PersonalisablePartie.NbLettreAlea;
	}
}
