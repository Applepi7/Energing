using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Slider timeBar;
    public GameObject ResultUI;
    public float speed = 20f;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        timeBar.value -= Time.deltaTime * speed;

        if(timeBar.value <= 0)
        {
            Time.timeScale = 0;
            ResultUI.SetActive(true);
        }
	}
}
