using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.deltaTime * 1;
    }
}
