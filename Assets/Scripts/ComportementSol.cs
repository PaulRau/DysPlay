using UnityEngine;
using System.Collections;

public class ComportementSol : MonoBehaviour {

    public GameObject coeurPrefab;
    public GameObject coeur;
    public GameObject canvas;
    public Sprite[] nbcoeur;
    private int vies;

    private bool aVie;

    void Start()
    {
        vies = 4;

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
        if (GameObject.Find("GameOver(Clone)") == null)
        {
            if (vies==0)
            {
                MotAleatoire.success = true;
                LettreAleatoire.success = true;
                Instantiate(canvas);
                Time.timeScale = 0.0f;

            }

        }
    }

    public int scoreValue = 1;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
            

        if (collision.gameObject.name == "LettreChoisie(Clone)" )
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
        }

        if (collision.gameObject.name == "LettreAleatoire(Clone)" || collision.gameObject.name == "LettreChoisiPerso(Clone)")
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

            if (aVie == true)
            {
                if (vies != 0)
                {
                    vies--;
                }// else fin de partie 
            }
        }


        if (collision.gameObject.name == "Mot(Clone)" || collision.gameObject.name == "MotAleatoire(Clone)" || collision.gameObject.name == "MotPerso(Clone)")
            {
                

                //detruit l'object Mot après O.5 secondes et arrête son mouvement en attendant
                Destroy(collision.gameObject, 0.5f);

                //collision.gameObject.GetComponent<LettreAleatoire>().speed = new Vector2(0, 0);

                //desactive le clavie
                MotAleatoire.success = true;
                LettreAleatoire.success = true;
                if (aVie == true)
                {
                    if (vies != 0)
                    {
                        vies--;
                    }// else fin de partie    
                }
            }
        
        
    }
}
