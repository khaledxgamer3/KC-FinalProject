using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faciing_right : MonoBehaviour
{
    SpriteRenderer player;
    bool facingright = true;
    Animator animation1;
   
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        animation1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        flipping();
        playeranimation();
      
    }
    void flipping()
    {
        if (facingright == false && Input.GetKeyDown(KeyCode.A))
        {
            player.flipX = false;
            facingright = true;
        }
        else if (facingright == true && Input.GetKeyDown(KeyCode.D))
        {
            player.flipX = true;
            facingright = false;
        }
    }

    void playeranimation()
    {
        float speed = Input.GetAxis("Horizontal");
        animation1.SetFloat("speed", Mathf.Abs(speed));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animation1.SetTrigger("jump");
        }

    }
}
