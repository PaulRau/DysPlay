using UnityEngine;
using System.Collections;

public class GenerateurFinDePartie : MonoBehaviour {

    public GameObject canvas;

    public static float ratio;

    public static float finDePartiePerso = 20;
   
	// Use this for initialization
	void Start () {
       
	}    
    

	// Update is called once per frame
	void Update () {


        if (GameObject.Find("FinDePartie (Canvas)(Clone)") == null)
        {
            if (ScoreManager.score >= finDePartiePerso)
            {



                if(ScoreManager.mauvaiseLettre != 0)
                {
                    Debug.Log(ratio);
                    ratio = ScoreManager.bonneLettre + ScoreManager.mauvaiseLettre;
                    Debug.Log(ratio);
                    ratio = ScoreManager.bonneLettre / ratio;
                    Debug.Log(ratio);
                    ratio = ratio * 100;
                    Debug.Log(ratio);
                    Debug.Log(ScoreManager.bonneLettre);
                    Debug.Log(ScoreManager.mauvaiseLettre);
                    Debug.Log(ratio);
                }
                else
                {
                    
                    ratio = 100;
                    Debug.Log(ScoreManager.bonneLettre);
                    Debug.Log(ScoreManager.mauvaiseLettre);
                    Debug.Log(ratio);
                }


                Instantiate(canvas);
                Time.timeScale = 0.0f;
                
            }

        }
          
     
            }
}
