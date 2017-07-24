﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Player : MonoBehaviour {

    public static Player instance;

    public Sprite[] Icons;
    /*
    0 에너지
    1 전기
    2 빛
    3 열
    4 운동
    5 전자
    6 화학
    */
    public int iconnum = 0; //기본 아이콘

    private SpriteRenderer playericon;
    private Transform tr;

    void Start()
    {
        Player.instance = this;
        playericon = GetComponent<SpriteRenderer>();
        tr = GetComponent<Transform>();
    }

	// Update is called once per frame
	void Update () {
        playericon.sprite = Icons[iconnum];
    }

    public int Color()
    {
        return iconnum;
    }
}
