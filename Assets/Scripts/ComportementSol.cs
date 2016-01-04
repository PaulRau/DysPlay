using UnityEngine;
using System.Collections;

public class ComportementSol : MonoBehaviour {



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Lettre")
        {
            //detruit la lettre
            Destroy(collision.gameObject);
        }


    }
}
