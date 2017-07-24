using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwipeManager : MonoBehaviour
{

    public static SwipeManager instance;

    public Transform playerTr;
    public bool canSwipe = true;

    private Vector2 firstPressPos;
    private Vector2 secondPressPos;
    private Vector2 currentSwipe;
    private Vector3 playerPos;
    private float x, y;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Swipe();

        playerPos = Player.instance.transform.position;
    }
    public void Swipe()
    {
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                //save began touch 2d point
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }

            if (t.phase == TouchPhase.Ended)
            {
                //save ended touch 2d point
                secondPressPos = new Vector2(t.position.x, t.position.y);

                //create vector from the two points
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                //normalize the 2d vector
                currentSwipe.Normalize();
                //swipe upwards
                if(canSwipe && currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    Player.instance.transform.position = new Vector3(Player.instance.transform.position.x, Player.instance.transform.position.y - 2, -3);
                }
                //swipe down
                if (canSwipe && currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    Player.instance.transform.position = new Vector3(Player.instance.transform.position.x, Player.instance.transform.position.y + 2, -3);
                }
                //swipe left
                if (canSwipe && currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    Player.instance.transform.position = new Vector3(Player.instance.transform.position.x - 2, Player.instance.transform.position.y, -3);
                }
                //swipe right
                if (canSwipe && currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    Player.instance.transform.position = new Vector3(Player.instance.transform.position.x + 2, Player.instance.transform.position.y, -2);
                }
            }
        }
    }

}
