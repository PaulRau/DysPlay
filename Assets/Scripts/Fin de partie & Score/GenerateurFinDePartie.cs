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

    string[] lines = { "First line", "Second line", "Third" };
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

               
                    apm = ScoreManager.bonneLettre * 60 / (int)Compteur.timeForAPM;

                   
           

                if(ScoreManager.mauvaiseLettre != 0)
                {
                    
                    ratio = ScoreManager.bonneLettre + ScoreManager.mauvaiseLettre;
                   
                    ratio = ScoreManager.bonneLettre / ratio;
                
                    ratio = ratio * 100;

                    ratio = (int)ratio;
               
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

               // System.IO.File.WriteAllText(@"C:\Users\Paul\Documents\DysPlay\test.txt", scoreStat);

                using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Paul\Documents\DysPlay\Stats\Partie.txt", true))
                {
                    file.WriteLine(partieStat);
                }

                using (System.IO.StreamWriter file =
         new System.IO.StreamWriter(@"C:\Users\Paul\Documents\DysPlay\Stats\Type.txt", true))
                {
                    file.WriteLine(typeStat);
                }

                using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\Paul\Documents\DysPlay\Stats\Score.txt", true))
                {
                    file.WriteLine(scoreStat);
                }

                using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\Paul\Documents\DysPlay\Stats\Ratio.txt", true))
                {
                    file.WriteLine(ratioStat);
                }

                using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\Paul\Documents\DysPlay\Stats\BLM.txt", true))
                {
                    file.WriteLine(blmStat + " %");
                }

                using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\Paul\Documents\DysPlay\Stats\Temps.txt", true))
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
        System.IO.File.WriteAllText(@"C:\Users\Paul\Documents\DysPlay\Stats\Partie.txt", "");
        System.IO.File.WriteAllText(@"C:\Users\Paul\Documents\DysPlay\Stats\Score.txt", "");
        System.IO.File.WriteAllText(@"C:\Users\Paul\Documents\DysPlay\Stats\Ratio.txt", "");
        System.IO.File.WriteAllText(@"C:\Users\Paul\Documents\DysPlay\Stats\BLM.txt", "");
        System.IO.File.WriteAllText(@"C:\Users\Paul\Documents\DysPlay\Stats\Temps.txt", "");
        System.IO.File.WriteAllText(@"C:\Users\Paul\Documents\DysPlay\Stats\Type.txt", "");
        Application.LoadLevel("Statistiques");
       GenerateurDePartiePerso.compteurNbPartie = 0;
     

    }
    

}
