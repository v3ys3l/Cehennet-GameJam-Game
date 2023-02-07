using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yerMelek : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D coll)
   {
        if (coll.gameObject.tag == "obstacle")
        {
            PlayerSeytan.isdead = true;
            Destroy(coll.gameObject);
        }    
   }
}
