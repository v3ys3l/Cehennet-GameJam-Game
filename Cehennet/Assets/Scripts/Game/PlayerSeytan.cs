using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSeytan : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;

    public static Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        move();
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
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
            Vector2 newscale = transform.localScale;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime * 1;
                newscale.x = -3f;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(speed, 0, 0) * Time.deltaTime * 1;
                newscale.x = 3f;
            }
            transform.localScale = newscale;
    }

    public static bool isdead;
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "obstacle")
        {
            isdead = true;
            Destroy(coll.gameObject);
        }
    }
}
