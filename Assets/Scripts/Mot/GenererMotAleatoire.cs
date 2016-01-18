using UnityEngine;
using System.Collections;

public class GenererMotAleatoire : MonoBehaviour
{

    public GameObject mot;
    // Use this for initialization

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        if(Compteur.timeRemaining < 0.01f)
        {
            if (GameObject.Find("LettreChoisie(Clone)") == null)
            {
                Instantiate(mot);
            }
        }
      

    }
}
