using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconManager : MonoBehaviour {
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
    public static IconManager instance;

    private int icon = 1;
    private SpriteRenderer IconRend;

	// Use this for initialization
	void Start () {
        IconRend = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        CreateIcon();
	}

    void CreateIcon()
    {
        IconRend.sprite = Icons[icon];
    }

    public void SetIcon(int ico)
    {
        icon = ico;
        IconRend.sprite = Icons[icon];
        Player.instance.IconID(ico);
        
    }

    public int retrunicon()
    {
        return icon;
    }
}
