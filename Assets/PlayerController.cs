using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void Start()
    {
        Application.targetFrameRate = 60;

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.08f, 0);
        }
            
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.08f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.08f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.08f, 0, 0);
        }
    }
            
        
        
            
}
