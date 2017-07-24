using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {
    public Transform playerTr;
    public GameObject Icon;
    public bool Onplayer = false;
    public bool IsEnable = true;
    public Color[] color;
    public GameObject[] othericons;
    public static TileManager instance;
    /*
    0 에너지(조커)   0
    1 전기(기본)    50
    2 빛(기본)     50
    3 열(기본)     50
    4 운동(에픽)    75
    5 전자(에픽)    75
    6 화학(에픽)    75
    */
    public int iconcolornum;
    public GameObject Score;

    private Transform tr;
    private SpriteRenderer IconRend;
    private int rand,randicon,iconsprnum;
    private bool Create = false;
    private int i = 0;
    private int id;

    void Start()
    {
        tr = GetComponent<Transform>();
        IconRend = GetComponent<SpriteRenderer>();
        IconCreate();
    }

    void Update()
    {
        if(tr.position.x==playerTr.position.x && tr.position.y == playerTr.position.y)
        {
            if (i < 1)
            {
                id = Player.instance.Color();
                Player.instance.IconID(iconsprnum);

                IconCreate();
                PlayerColor();
                i++;
                if (id >= 1 && id <= 3)
                {
                    Score.GetComponent<Score>().ScoreUp(50);
                    GameManager.instance.timeBar.value += 10;
                }
                else if (id >= 4 && id <= 6)
                {
                    Score.GetComponent<Score>().ScoreUp(75);
                    GameManager.instance.timeBar.value += 20;
                }
            }
            
            Icon.SetActive(false);
        }
        else
        {
            Onplayer = false;
            IconColor();
            Icon.SetActive(true);
            IsEnable = true;
            i = 0;
        }
    }

    void IconCreate()
    {
            for (int i = 0; i < othericons.Length; i++)
            {
                while (true)
                {
                    IconRand();
                    if (iconsprnum != othericons[i].GetComponent<IconManager>().retrunicon())
                    {
                        break;
                    }
                }
            }
            Icon.GetComponent<IconManager>().SetIcon(iconsprnum);
            Create = false;
        
    }

    void IconRand()
    {

        rand = Random.Range(1, 100);
        if (rand > 95)
        {
            iconsprnum = 0;
        }
        if (rand > 60 && rand <= 95)
        {
            randicon = Random.Range(1, 9);
            if (randicon % 2 == 0 && randicon % 3 != 0)
            {
                iconsprnum = 4;
            }
            else if (randicon % 3 == 0)
            {
                iconsprnum = 5;
            }
            else
            {
                iconsprnum = 6;
            }
        }
        else if (rand<=60)
        {
            randicon = Random.Range(1, 9);
            if(randicon%2==0&&randicon%3!=0)
            {
                iconsprnum = 1;
            }
            else if(randicon % 3 == 0)
            {
                iconsprnum = 2;
            } else
            {
                iconsprnum = 3;
            }
        }

    }

    void IconColor()
    {
        iconcolornum = iconsprnum;
        IconRend.color = color[iconcolornum];
    }

    void PlayerColor()
    {
        iconcolornum = playerTr.gameObject.GetComponent<Player>().Color();
        IconRend.color = color[iconcolornum];
    }
}
