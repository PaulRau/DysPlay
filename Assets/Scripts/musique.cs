using UnityEngine;
using System.Collections;

public class musique : MonoBehaviour {


    public AudioClip musiquedeFond;

    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        source.volume = MenuScript.currentMusicVolume;
        

    }
	// Use this for initialization
	void Start () {

      

    
	}
	
	// Update is called once per frame
	void Update () {

        if (!source.isPlaying)
        {

            source.PlayOneShot(musiquedeFond);
        }
	
	}
}
