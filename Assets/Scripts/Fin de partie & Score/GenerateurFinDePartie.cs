using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System;


public class GenerateurFinDePartie : MonoBehaviour {

    public GameObject canvas;

    public static float ratio;

    public static float finDePartiePerso = 20;
    public static int But;
    public static int MotsValide = 0;

    public static int apm;

    
    
    string scoreStat;
    string partieStat;
    string blmStat;
    string ratioStat;
    string tempsStat;
    string typeStat;
    int cutToInt;


	// Use this for initialization
	void Start () {
        
	}    
    

	// Update is called once per frame
	void Update () {


        if (GameObject.Find("FinDePartie (Canvas)(Clone)") == null)
        {
            if (ScoreManager.score >= finDePartiePerso || MotsValide >= But)
            {

               
                    apm = (int)(ScoreManager.bonneLettre * 60 / Compteur.timeForAPM);

                   
           

                if(ScoreManager.mauvaiseLettre != 0)
                {
                    
                    ratio = ScoreManager.bonneLettre + ScoreManager.mauvaiseLettre;
                   
                    ratio = ScoreManager.bonneLettre / ratio;
                
                    ratio = (int)(ratio * 100);

                   
               
                }
                else
                {
                    
                    ratio = 100;
                
                }
                            
                
                cutToInt = (int)Compteur.timeForAPM;
                tempsStat = cutToInt.ToString();

                if (GenerateurDePartiePerso.statPartiePerso == true)
                {
                    typeStat = "Personnalisable";
                }
                else typeStat = "Niveaux";

                scoreStat = ScoreManager.score.ToString();
                ratioStat = ratio.ToString();
                blmStat = apm.ToString();
                partieStat = GenerateurDePartiePerso.compteurNbPartie.ToString();


               // FileStream filaz = File.Open(Application.persistentDataPath + "/Test.txt", FileMode.Open);
              // Debug.Log(Application.persistentDataPath);
               
                if (!System.IO.File.Exists(Application.persistentDataPath + "/Partie.txt"))
                {
                    System.IO.File.WriteAllText(Application.persistentDataPath + "/Partie.txt", "");
                }

                if (!System.IO.File.Exists(Application.persistentDataPath + "/Type.txt"))
                {
                    System.IO.File.WriteAllText(Application.persistentDataPath + "/Type.txt", "");
                }

                if (!System.IO.File.Exists(Application.persistentDataPath + "/Score.txt"))
                {
                    System.IO.File.WriteAllText(Application.persistentDataPath + "/Score.txt", "");
                }

                if (!System.IO.File.Exists(Application.persistentDataPath + "/Ratio.txt"))
                {
                    System.IO.File.WriteAllText(Application.persistentDataPath + "/Ratio.txt", "");
                }

                if (!System.IO.File.Exists(Application.persistentDataPath + "/BLM.txt"))
                {
                    System.IO.File.WriteAllText(Application.persistentDataPath + "/BLM.txt", "");
                }

                if (!System.IO.File.Exists(Application.persistentDataPath + "/Temps.txt"))
                {
                    System.IO.File.WriteAllText(Application.persistentDataPath + "/Temps.txt", "");
                }

               
                using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(Application.persistentDataPath + "/Partie.txt", true))
                {
                    file.WriteLine(partieStat);
                }

                using (System.IO.StreamWriter file =
         new System.IO.StreamWriter(Application.persistentDataPath + "/Type.txt", true))
                {
                    file.WriteLine(typeStat);
                }

                using (System.IO.StreamWriter file =
        new System.IO.StreamWriter(Application.persistentDataPath + "/Score.txt", true))
                {
                    file.WriteLine(scoreStat);
                }

                using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(Application.persistentDataPath + "/Ratio.txt", true))
                {
                    file.WriteLine(ratioStat + " %");
                }

                using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(Application.persistentDataPath + "/BLM.txt", true))
                {
                    file.WriteLine(blmStat);
                }

                using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(Application.persistentDataPath + "/Temps.txt", true))
                {
                    file.WriteLine(tempsStat + " secondes");
                }




                Instantiate(canvas);
                Time.timeScale = 0.0f;
                
            }

        }
          
     
            }

    public void supprimerTout()
    {
        System.IO.File.WriteAllText(Application.persistentDataPath + "/Partie.txt", "");
        System.IO.File.WriteAllText(Application.persistentDataPath + "/Score.txt", "");
        System.IO.File.WriteAllText(Application.persistentDataPath + "/Ratio.txt", "");
        System.IO.File.WriteAllText(Application.persistentDataPath + "/BLM.txt", "");
        System.IO.File.WriteAllText(Application.persistentDataPath + "/Temps.txt", "");
        System.IO.File.WriteAllText(Application.persistentDataPath + "/Type.txt", "");
        Application.LoadLevel("Statistiques");
       GenerateurDePartiePerso.compteurNbPartie = 0;
     

    }
    

}
