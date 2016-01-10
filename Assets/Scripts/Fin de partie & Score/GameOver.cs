using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{

    public GameObject canvas;


    // Use this for initialization
    void Start()
    {


    }





    // Update is called once per frame
    void Update()
    {


        if (GameObject.Find("GameOver(Clone)") == null)
        {
            if (ScoreManager.score >= 15)
            {
                MotAleatoire.success = true;
                LettreAleatoire.success = true;
                Instantiate(canvas);
                Time.timeScale = 0.0f;
                
            }

        }

    }
}
