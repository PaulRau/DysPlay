using UnityEngine;


/// <summary>
/// Déplace l'objet
/// </summary>

public class ComportementLettre : MonoBehaviour
{
    // 1 - Designer variables
    
    

    /// <summary>
    /// Vitesse de déplacement
    /// </summary>
    public Vector2 speed = new Vector2(10, 10);

    
    /// <summary>
    /// Direction
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);


    private Vector2 movement;

    // Instanciation des GameObject et des Sprites

    public GameObject letter;
    public GameObject letterPrefab;
    public Sprite alphabet_D;

    void start()
    {
       

        letter = Instantiate(letterPrefab);
        
    }
   
    
   

    void Update()
    {


        letter.GetComponent<SpriteRenderer>().sprite = alphabet_D;

        // 2 - Calcul du mouvement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);


        if (Input.GetKeyDown("a"))
        { 
            Destroy(gameObject);
        }
         
    }

   void FixedUpdate()    
    {
        // Application du mouvement
        GetComponent<Rigidbody2D>().velocity = movement;
    }




   
}