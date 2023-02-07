using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yerSeytan : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "obstacle")
        {
            Destroy(coll.gameObject);
        }
    }
}
