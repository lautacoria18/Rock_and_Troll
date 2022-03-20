using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{

    void Start()
    {
        Invoke("SelfDestruct", 2.0f);
    }

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
