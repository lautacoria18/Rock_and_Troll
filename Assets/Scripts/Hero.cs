using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

    private Rigidbody2D rb;
    private float horizontalInput;
    private float direction = 0;
    public float SpeedMove;
    private Animator anim;
    public Animator smokeAnimator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        if (!Pause.GameIsPaused)
        {
            if (!GameOver.itsOver)
            {

                heroMovement();
                
            }
        }
    }


    void heroMovement() {


        direction = horizontalInput;
        horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector2 dir = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        Vector2 horizontalMove = Vector2.right * dir * SpeedMove * Time.deltaTime;
        rb.MovePosition(rb.position + horizontalMove);


        //Cambiar el lado del personaje al moverse.
        if (horizontalInput < 0.0f) transform.localScale = new Vector3(-5.0f, 5.0f, 5.0f);
        else if (horizontalInput > 0.0f) transform.localScale = new Vector3(5.0f, 5.0f, 5.0f);

        //Animaciones
        anim.SetBool("Running", horizontalInput != 0.0f);
        smokeAnimator.SetBool("Smoking", horizontalInput != 0.0f);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin") {
            GameManager.Score++;
            SoundManager.PlaySound("coin");
            Destroy(col.gameObject);
        }
        
    }


}