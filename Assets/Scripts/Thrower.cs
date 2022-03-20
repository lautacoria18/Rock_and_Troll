using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{

    private Animator anim;
    public Transform rock;
    public Transform thrower;

    public float minAngle, maxAngle;
    public float minSpeed, maxSpeed;
    public float minTime, maxTime;
    private float time;


    void Start()
    {
        
        anim = GetComponent<Animator>();
        StartCoroutine(Throw());
     
    }

    private IEnumerator Throw()
    {
        //Utilizando recursion, hago que cada X segundos arroje la piedra
        time = Random.Range(minTime, maxTime);
        yield return new WaitForSeconds(time);
        anim.SetTrigger("Throws");
        SoundManager.PlaySound("throw");
        yield return new WaitForSeconds(0.1f);
        Transform rockInstantiated = Instantiate(rock, transform.position, Quaternion.identity);

        //Dentro de la roca recientemente instanciada, le seteo valores aleatorios de un rango específico.
        rockInstantiated.GetComponent<Rock>().angle = Random.Range(minAngle, maxAngle);
        rockInstantiated.GetComponent<Rock>().speed = Random.Range(minSpeed, maxSpeed);
        rockInstantiated.GetComponent<Rock>().strength = Random.Range(-6f, 10f);
        StartCoroutine(Throw());

    }
}
