using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mekik : MonoBehaviour
{

    public bool isDead;

    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public Game game;
   
    void Update()
    {
        //týklama
       if(Input.GetMouseButtonDown(0))
        {
            //sýçrama
            rb2D.velocity = Vector2.up * velocity; 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Benzin")
        {
            game.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea") ;
        {
            isDead = true;
            Time.timeScale = 0;

        }
    }
}
