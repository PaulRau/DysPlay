﻿using UnityEngine;
using System.Collections;

public class ComportementSol : MonoBehaviour {

    public GameObject coeurPrefab;
    public GameObject coeur;
    public GameObject canvas;
    public Sprite[] nbcoeur;
   public static int vies;

    private bool aVie;

    void Start()
    {
        vies = 5;

        aVie = PersonalisablePartie.OuiNonVie;

        if(aVie == true)
        {
            coeur = Instantiate(coeurPrefab);
        }
      
       
        

    } 
    
    void Update()
    {
          if(aVie == true)
        {
        coeur.GetComponent<SpriteRenderer>().sprite = nbcoeur[vies];
        }
          if (GameObject.Find("GameOver (Canvas)(Clone)") == null)
        {
            if (vies==0)
            {


                GenerateurFinDePartie.apm = ScoreManager.bonneLettre * 60 / (int)Compteur.timeForAPM;


                if (ScoreManager.mauvaiseLettre != 0)
                {

                  GenerateurFinDePartie.ratio = ScoreManager.bonneLettre + ScoreManager.mauvaiseLettre;

                  GenerateurFinDePartie.ratio = ScoreManager.bonneLettre / GenerateurFinDePartie.ratio;

                  GenerateurFinDePartie.ratio = GenerateurFinDePartie.ratio * 100;

                }
                else
                {

                    GenerateurFinDePartie.ratio = 100;

                }
                
                MotAleatoire.success = true;
                LettreAleatoire.success = true;
                MotAleaPerso.success = true;
                LettreChoisiePerso.success = true;
                Mot.success = true;
                NiveauUn.success = true;
                NiveauDeux.success = true;
                NiveauTrois.success = true;
                NiveauQuatre.success = true;
                Vacances1.success = true;
                Vacances2.success = true;
                Sport1.success = true;
                Sport2.success = true;
                Jungle1.success = true;
                Jungle2.success = true;
                Campagne1.success = true;
                Campagne2.success = true;

                Instantiate(canvas);
                Time.timeScale = 0.0f;

            }

        }
    }

    public int scoreValue = 1;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
            

        if (collision.gameObject.name == "LettreChoisie(Clone)" || collision.gameObject.name == "LettreMotNiveau(Clone)" )
        {
            //Modifie le score
            ScoreManager.score -= scoreValue;
            if (ScoreManager.score < 0) ScoreManager.score = 0;

                

            //detruit la lettre au bout de 0.5 secondes, met la lettre en rouge, et stope son mouvement
            Destroy(collision.gameObject, 0.5f);

            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            //collision.gameObject.GetComponent<LettreAleatoire>().speed = new Vector2(0, 0);


            //desactive le clavie
            MotAleatoire.success = true;
            LettreAleatoire.success = true;
            MotAleaPerso.success = true;
            LettreChoisiePerso.success = true;
            Mot.success = true;
            NiveauUn.success = true;
            NiveauDeux.success = true;
            NiveauTrois.success = true;
            NiveauQuatre.success = true;

            Combo.combo = 0;
            
        }

        if (collision.gameObject.name == "LettreAleatoire(Clone)" || collision.gameObject.name == "LettreChoisiPerso(Clone)" || collision.gameObject.name == "LettreNiveau(Clone)")
        {
            //Modifie le score
            ScoreManager.score -= scoreValue;
            if (ScoreManager.score < 0) ScoreManager.score = 0;



            //detruit la lettre au bout de 0.5 secondes, met la lettre en rouge, et stope son mouvement
            Destroy(collision.gameObject, 0.5f);

            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            //collision.gameObject.GetComponent<LettreAleatoire>().speed = new Vector2(0, 0);


            //desactive le clavie
            MotAleatoire.success = true;
            LettreAleatoire.success = true;
            LettreChoisiePerso.success = true;
            Mot.success = true;
            NiveauUn.success = true;
            NiveauDeux.success = true;
            NiveauTrois.success = true;
            NiveauQuatre.success = true;

            Combo.combo = 0;


            if (aVie == true)
            {
                if (vies > 0)
                {
                    vies--;
                }// else fin de partie 
            }
        }


        if (collision.gameObject.name == "Mot(Clone)" || collision.gameObject.name == "MotAleatoire(Clone)" || collision.gameObject.name == "MotChoisiPerso(Clone)" || collision.gameObject.name == "MotAleaPerso(Clone)" || collision.gameObject.name == "Clone(Clone)")
            {
                

                //detruit l'object Mot après O.5 secondes et arrête son mouvement en attendant
                Destroy(collision.gameObject, 0.5f);

                //collision.gameObject.GetComponent<LettreAleatoire>().speed = new Vector2(0, 0);

                //desactive le clavie
                MotAleatoire.success = true;
                LettreAleatoire.success = true;
                LettreChoisiePerso.success = true;
                Mot.success = true;
                NiveauUn.success = true;
                NiveauDeux.success = true;
                Vacances1.success = true;
            Vacances2.success = true;
            Sport1.success = true;
            Sport2.success = true;
            Jungle1.success = true;
            Jungle2.success = true;
            Campagne1.success = true;
            Campagne2.success = true;

            Combo.combo = 0;

            if (aVie == true)
                {
                    if (vies > 0)
                    {
                        vies--;
                    }// else fin de partie    
                } 
            }
        
        
    }
}
