using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelek : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;

    public static Animator anim;

    public static bool ismoving = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        move();
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
    }

    void move()
    {
        if (ismoving)
        { 
            Vector2 newscale = transform.localScale;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime * 1;
            newscale.x = -3f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime * 1;
            newscale.x = 3f;
        }
        transform.localScale = newscale;
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "obstacle")
        {
            Destroy(coll.gameObject);   
        }
    }
}
