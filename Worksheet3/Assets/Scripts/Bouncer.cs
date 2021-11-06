using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public int health = 100;
    Rigidbody2D rb;



   
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(400f, 200f));
     
     
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        health -= 10;
        Color color = GetComponent<SpriteRenderer>().color;
        color.a -= 0.1f;
        GetComponent<SpriteRenderer>().color = color;
        Debug.Log("Health: " + health);

       if (health <= 0) {
            Destroy(this.gameObject);
        }
    }


}
