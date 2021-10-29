using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stickController_pc : MonoBehaviour
{
    
    [SerializeField] Camera cam;

    
    private void Start()
    {
        
    }
    void Update()
    {
        float routeStick = Input.GetAxis("Horizontal");

        //this.transform.position = new Vector3(-routeStick * 15 * Time.deltaTime,0,0);
        

        float maxWidth = 1 / (cam.WorldToViewportPoint(new Vector3(1, 1, 0)).x - .5f);

        if (transform.position.x > -((maxWidth / 2) *0.9) && transform.position.x < ((maxWidth / 2) * 0.9))
        {
            transform.Translate(new Vector2(routeStick * 3 * Time.deltaTime, 0));
        }

        if (transform.position.x < -((maxWidth / 2) * 0.9))
        {
            transform.position = new Vector2((float)(-((maxWidth / 2) * 0.87)), -1.83f);
        }

        if (transform.position.x > ((maxWidth / 2) * 0.9))
        {
            transform.position = new Vector2((float)(((maxWidth / 2) * 0.87)), -1.83f);
        }
        Debug.Log(((maxWidth / 2) * 0.9));

    }
}
