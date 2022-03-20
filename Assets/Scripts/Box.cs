using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    //Factor de rebote vertical
    [Range(0, 2)]
    public int verticalBounceFactor;
    public static int vbf;

    [Range(0, 2)]
    public int horizontalBounceFactor;
    public static int hbf;


    void Start()
    {
        vbf = verticalBounceFactor;
        hbf = horizontalBounceFactor;
    }

}
