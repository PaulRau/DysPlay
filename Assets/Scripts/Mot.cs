using UnityEngine;
using System.Collections;

public class Mot : MonoBehaviour {

    private string liste = "eau";
    private int i = 0;
    public GameObject letter;

	// Use this for initialization
	void Start () {

        char[] characters = liste.ToCharArray();


        //Debug.Log(characters[1]);
        for (i = 0; i < liste.Length; i++)
        {
            AfficheLettre(characters[i]);
        }
    }

    void AfficheLettre(char charactere)
    {
        switch (charactere)
        {
            case 'a':
                LettreChoisie.type = 0;
                Instantiate(letter);
            break;
            case 'b':
                LettreChoisie.type = 1;
                Instantiate(letter);
                break;
            case 'c':
                LettreChoisie.type = 2;
                Instantiate(letter);
                break;
            case 'd':
                LettreChoisie.type = 3;
                Instantiate(letter);
                break;
            case 'e':
                LettreChoisie.type = 4;
                Instantiate(letter);
                break;
            case 'f':
                LettreChoisie.type = 5;
                Instantiate(letter);
                break;
            case 'g':
                LettreChoisie.type = 6;
                Instantiate(letter);
                break;
            case 'h':
                LettreChoisie.type = 7;
                Instantiate(letter);
                break;
            case 'i':
                LettreChoisie.type = 8;
                Instantiate(letter);
                break;
            case 'j':
                LettreChoisie.type = 9;
                Instantiate(letter);
                break;
            case 'k':
                LettreChoisie.type = 10;
                Instantiate(letter);
                break;
            case 'l':
                LettreChoisie.type = 11;
                Instantiate(letter);
                break;
            case 'm':
                LettreChoisie.type = 12;
                Instantiate(letter);
                break;
            case 'n':
                LettreChoisie.type = 13;
                Instantiate(letter);
                break;
            case 'o':
                LettreChoisie.type = 14;
                Instantiate(letter);
                break;
            case 'p':
                LettreChoisie.type = 15;
                Instantiate(letter);
                break;
            case 'q':
                LettreChoisie.type = 16;
                Instantiate(letter);
                break;
            case 'r':
                LettreChoisie.type = 17;
                Instantiate(letter);
                break;
            case 's':
                LettreChoisie.type = 18;
                Instantiate(letter);
                break;
            case 't':
                LettreChoisie.type = 19;
                Instantiate(letter);
                break;
            case 'u':
                LettreChoisie.type = 20;
                Instantiate(letter);
                break;
            case 'v':
                LettreChoisie.type = 21;
                Instantiate(letter);
                break;
            case 'w':
                LettreChoisie.type = 22;
                Instantiate(letter);
                break;
            case 'x':
                LettreChoisie.type = 23;
                Instantiate(letter);
                break;
            case 'y':
                LettreChoisie.type = 24;
                Instantiate(letter);
                break;
            case 'z':
                LettreChoisie.type = 25;
                Instantiate(letter);
                break;
        }
        

    }
	// Update is called once per frame
	void Update () {
	
	}
}
