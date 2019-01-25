using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isJump = false;
    public bool gameOver = false;
    public int jump = 0;
    public string scoretext=0+" ";
    public string GameOver;

    public Sprite catjump;
    public Sprite catstand;

    public AudioSource jumpaudio;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space) && !isJump)
        {
            isJump = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
            GetComponent<SpriteRenderer>().sprite = catjump;
            jump = jump + 1;
            scoretext = jump+" ";
            jumpaudio.Play();
        }
        if (gameOver)
        {
            GetComponent<Transform>().localScale= new Vector3(10, 5, 1);
            GameOver = "Game Over";
            isJump = true;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameOver)
        {
            isJump = true;
        }

        isJump = false;
        GetComponent<SpriteRenderer>().sprite = catstand;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.tag == "MovingRope" && !isJump)
        {
            gameOver = true;
        }


    }


  
}