using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class genvolumemusicslider : MonoBehaviour {


    public GameObject sliderMusic;
    public GameObject sliderMusicPrefab;

   

    public Canvas Canvanas;

	// Use this for initialization
	void Start () {

        sliderMusic = (GameObject) Instantiate(sliderMusicPrefab, new Vector2(0.5f,0.5f), Quaternion.identity);
        sliderMusic.transform.SetParent(Canvanas.transform);
        sliderMusic.GetComponent<Slider>().value = MenuScript.currentMusicVolume;
        sliderMusic.GetComponent<Transform>().localPosition = new Vector2(172,65);
        sliderMusic.GetComponent<Transform>().localScale = new Vector2(3, 3);
	// 172x 65y 0z 181width 17 height x0.5 y0.5 sclae x3 y3 z1

	}
	
	// Update is called once per frame
	void Update () {
	



	}
}
