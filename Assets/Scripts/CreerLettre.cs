using UnityEngine;
using System.Collections;

public class CreerLettre : MonoBehaviour {

    public GameObject letter;
	// Use this for initialization

	void Start () {

        Instantiate(letter);
	
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Lettre(Clone)")==null)
        {
            Instantiate(letter);
        }
    }
}
