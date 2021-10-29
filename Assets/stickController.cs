using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickController : MonoBehaviour
{
    [SerializeField] GameObject stick;
    [SerializeField] bool moveRight = false;
    [SerializeField] bool moveLeft = false;

    private void Update()
    {
        if (moveLeft)
        {
            stick.transform.Translate(new Vector2(-1 * 3 * Time.deltaTime, 0));
        }
        else if (moveRight) {
            stick.transform.Translate(new Vector2(1 * 3 * Time.deltaTime, 0));

        } else {
            stick.transform.Translate(new Vector2(0 * 3 * Time.deltaTime, 0));
        }
    }

    public void routeRight(bool a)
    {
        moveRight = a;
    }

    public void routeLeft(bool a)
    {
        moveLeft = a;
    }
}
