using UnityEngine;
using System.Collections;

public class GenerateurFinDePartie : MonoBehaviour {

    public GameObject canvas;

    public static float finDePartiePerso = 15;
   
	// Use this for initialization
	void Start () {

       
	}
	

    
    

	// Update is called once per frame
	void Update () {


        if (GameObject.Find("Canvas(Clone)") == null)
        {
            if (ScoreManager.score >= finDePartiePerso)
            {
                Instantiate(canvas);
                Time.timeScale = 0.0f;
                //pas oublié de remettre la partie en route !
            }

        }
        

      
     
            

	}
}
