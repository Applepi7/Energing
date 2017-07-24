using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public int score;
    public Text scoreText;
    public Text rText;

    public static Score instance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "점수 : " + score;
    }

    public void ScoreUp(int scr)
    {
        score += scr;
    }
}
