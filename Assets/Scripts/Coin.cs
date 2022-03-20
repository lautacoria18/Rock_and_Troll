using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float timeToSelfDestruct;

    void Start()
    {
        if (GameManager.Difficult)
        {
            timeToSelfDestruct /= 1.5f;
        }

        Destroy(gameObject, timeToSelfDestruct);
    }

    void Update()
    {
        transform.Rotate(0, 180 * Time.deltaTime, 0);
    }

}
