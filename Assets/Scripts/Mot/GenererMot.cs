using UnityEngine;
using System.Collections;

public class GenererMot : MonoBehaviour
{

    public GameObject mot;
    // Use this for initialization

    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameObject.Find("LettreChoisie(Clone)") == null)
        {
            Instantiate(mot);
        }
        
    }
}