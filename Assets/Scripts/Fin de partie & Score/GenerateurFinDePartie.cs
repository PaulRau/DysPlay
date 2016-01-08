using UnityEngine;
using System.Collections;

public class GenerateurFinDePartie : MonoBehaviour {

    public GameObject canvas;

   
	// Use this for initialization
	void Start () {

       
	}
	

    
    

	// Update is called once per frame
	void Update () {


        if (GameObject.Find("Canvas(Clone)") == null)
        {
            if (ScoreManager.score >= 15)
            {
                Instantiate(canvas);
                Time.timeScale = 0.0f;
                //pas oublié de remettre la partie en route !
            }

        }
        

      
     
            

	}
}
