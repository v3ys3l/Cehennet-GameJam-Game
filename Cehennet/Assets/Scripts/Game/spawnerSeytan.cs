using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerSeytan : MonoBehaviour
{

    public GameObject[] obstacles;
    public float minTime, maxTime;
    void Update()
    {
        if (objectSpawnCoroutine == null)
        {
            objectSpawnCoroutine = StartCoroutine(objectSpawn(Random.Range(minTime, maxTime)));
        }
    }
    Coroutine objectSpawnCoroutine = null;
    IEnumerator objectSpawn(float time)
    {
        int RandomNum=Random.Range(0, obstacles.Length);
        GameObject obstacle=Instantiate(obstacles[RandomNum],gameObject.transform.position+new Vector3(Random.Range(7.26f, 1.14f),0,0),Quaternion.identity);
        yield return new WaitForSeconds(time);
        objectSpawnCoroutine = null;
    }
}
