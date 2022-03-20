using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Hero;

    void Update()
    {
        FollowHero();
    }

    private void FollowHero() {
        Vector3 position = transform.position;
        position.x = Hero.transform.position.x;
        transform.position = position;
    }
}
