using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Page : MonoBehaviour {

    public static Page instance;

    public Text page;
    public int pageNum = 1;

	// Use this for initialization
	void Start () {
        Page.instance = this;
	}
	
	// Update is called once per frame
	void Update () {
        page.text = pageNum + " / 3";
	}
}
