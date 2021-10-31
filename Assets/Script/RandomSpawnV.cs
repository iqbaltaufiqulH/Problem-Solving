using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnV : MonoBehaviour
{
    public GameObject Object;
    public int banyakobject;

    private void Start()
    {
        for (int i = 0; i < banyakobject; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(6, -6), Random.Range(5f, -5f));
            Instantiate(Object, randomPos, Quaternion.identity);
        }
    }
}