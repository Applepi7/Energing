using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ResultScore : MonoBehaviour {

    public Text rScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rScore.text = "." + Score.instance.score;
	}
}
