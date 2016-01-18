using UnityEngine;
using System.Collections;

public class GenerateurFinDePartie : MonoBehaviour {

    public GameObject canvas;

    public static float ratio;

    public static float finDePartiePerso = 20;

    public static int apm;
   
	// Use this for initialization
	void Start () {
       
	}    
    

	// Update is called once per frame
	void Update () {


        if (GameObject.Find("FinDePartie (Canvas)(Clone)") == null)
        {
            if (ScoreManager.score >= finDePartiePerso)
            {

               
                    apm = ScoreManager.bonneLettre * 60 / (int)Compteur.timeForAPM;
                
                
           

                if(ScoreManager.mauvaiseLettre != 0)
                {
                    
                    ratio = ScoreManager.bonneLettre + ScoreManager.mauvaiseLettre;
                   
                    ratio = ScoreManager.bonneLettre / ratio;
                
                    ratio = ratio * 100;
               
                }
                else
                {
                    
                    ratio = 100;
                
                }


                Instantiate(canvas);
                Time.timeScale = 0.0f;
                
            }

        }
          
     
            }
}
