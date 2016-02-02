using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class genvolumemusicslider : MonoBehaviour {


    public GameObject sliderMusic;
    public GameObject sliderMusicPrefab;

    public GameObject sliderSon;
    public GameObject sliderSonPrefab;



   

    public Canvas Canvanas;

	// Use this for initialization
	void Start () {



        sliderMusic = (GameObject) Instantiate(sliderMusicPrefab, new Vector2(0.5f,0.5f), Quaternion.identity);
        sliderMusic.transform.SetParent(Canvanas.transform);
        sliderMusic.GetComponent<Slider>().value = MenuScript.currentMusicVolume;
        sliderMusic.GetComponent<Transform>().localPosition = new Vector2(172,65);
        sliderMusic.GetComponent<Transform>().localScale = new Vector2(3, 3);

        sliderSon = (GameObject)Instantiate(sliderSonPrefab, new Vector2(0.5f, 0.5f), Quaternion.identity);
        sliderSon.transform.SetParent(Canvanas.transform);
        sliderSon.GetComponent<Slider>().value = MenuScript.currentVolume;
        sliderSon.GetComponent<Transform>().localPosition = new Vector2(120, 175);
        sliderSon.GetComponent<Transform>().localScale = new Vector2(3, 3);


	}
	
	// Update is called once per frame
	void Update () {
	



	}
}
