using UnityEngine;


/// <summary>
/// Déplace l'objet
/// </summary>

public class LettreChoisie : MonoBehaviour
{
    // 1 - Designer variables

    //public int scoreValue = 1;

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
    public static int type;              //rand est ici amené à être modifié dans un autre script pour déterminer la lettre qui doit être affichée
    public Vector2 newPos = new Vector2(0, 8);


    void Start()
    {
         
    }

    void Update()
    {
        // mouvement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);

        
    }

    void FixedUpdate()
    {
        // Application du mouvement
        GetComponent<Rigidbody2D>().velocity = movement;
    }



}

