using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        Application.targetFrameRate = 60;
        this.anim = GetComponent<Animator>();

    }

    void Update()
    {
        float y = Input.GetAxisRaw("Vertical");

        if (y == 0)
        {
            anim.Play("Player");
        }
        else if (y == 1)
        {
            anim.Play("PlayerL");
        }
        else
        {
            anim.Play("PlayerR");
        }

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

        if(transform.position.y < -3)
        {
            SceneManager.LoadScene("TitleScene");
        }


    }
            
        
        
            
}
