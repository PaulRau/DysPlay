using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateSliderVitesse : MonoBehaviour {


    public Text text;
    // Use this for initialization

    void Awake()
    {

        text = GetComponent<Text>();



    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Vitesse des lettres/mots: " + PersonalisablePartie.vitesse;
    }
}
