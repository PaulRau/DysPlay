using UnityEngine;
using System.Collections;

public class CreerLettreAleatoire : MonoBehaviour {

    public GameObject letter;
	// Use this for initialization

	void Start () {

        Instantiate(letter);
	
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("LettreAleatoire(Clone)")==null)
        {
            Instantiate(letter);
        }
    }
}
