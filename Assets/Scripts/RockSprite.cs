using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSprite : MonoBehaviour
{

    void Update()
    {
        Rotate();    
    }

    private void Rotate() {
        if (transform.position.y == -4.0f)
        {
            transform.Rotate(0, 0, 0);
        }
        else
        {
            transform.Rotate(0, 0, -180 * Time.deltaTime);
        }
    }
}
