using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rock : MonoBehaviour
{
    public float speed, strength, angle;

    public Vector3 goalTarget;


    Vector3 _startPosition;
    float stepScale;
    float progress;


    private Rigidbody2D rb;
    private GameObject box;
    public GameObject rockSprite;
    public Transform guidePrefab;
    float distance;


    Vector3 vSpeed = new Vector3(1f, 0f, 0f);

    Vector3 v = new Vector3(0f, -4f, -9f);

    Vector3 vectorFinal;

    public bool touch;
    public bool lastBounce;
    public bool isBouncing;
    public bool floorTouched;
    public bool canInstantiate;

    void Start()
    {
        canInstantiate = false;
        setValues();
        Invoke("activeInstantiate", 1f);
        applyDifficult();
        applyVerticalBounceFactor();
        applyHorizontalBounceFactor();
        applyBouncePhysics();
        instantiateGuide();

        touch = false;
        Debug.Log(speed);
    }

    void Update()
    {
        checkFinalBounce();
        parabolicMove();
        checkFinalPosition();
        checkCollisionWithBox();   
    }

    public void setValues() {

        box = GameObject.FindWithTag("Resorte");
        rb = GetComponent<Rigidbody2D>();
        _startPosition = transform.position;
        distance = 6.50f;


        stepScale = speed / distance;

        vSpeed *= strength;
        v += vSpeed;


    }

    public void applyBouncePhysics() {

        if (isBouncing)
        {
            Vector3 sumVec = new Vector3(5f, -4f, 0f);
            Vector3 fixVec = new Vector3(1f, 0f, 1f);
            Vector3 position;
            position = Vector3.Scale(_startPosition, fixVec);
            v = position + sumVec;
        }
    }

    public void instantiateGuide() {

        if (!touch && !GameManager.Difficult)
        {
            Instantiate(guidePrefab, v, Quaternion.identity);
        }
    }

    public void applyDifficult()
    {
        if (!isBouncing)
        {
            if (GameManager.Difficult)
            {
                speed *= 1.5f;
            }
        }
    }

    public void applyVerticalBounceFactor() {
        if (isBouncing)
        {
            if (Box.vbf < 1)
            {
                angle -= 0.25f;
            }
            else if (Box.vbf > 1)
            {
                angle += 0.2f;
            }

        }
    }

    public void applyHorizontalBounceFactor()
    {

        if (isBouncing)
        {
            if (Box.hbf < 1)
            {

                speed -= 0.5f;

            }
            else if (Box.hbf > 1)
            {

                speed += 0.5f;
            }
        }
    }

    public void activeInstantiate() {

        canInstantiate = true;
    }


    public void checkFinalBounce() {

        if (lastBounce)
        {
            vectorFinal = goalTarget;
            rockSprite.GetComponent<SpriteRenderer>().color = Color.yellow;

        }

        else
        {
            vectorFinal = v;

        }

    }

    public void parabolicMove() {

   
        progress = Mathf.Min(progress + Time.deltaTime * stepScale, 1.0f);
  
        float parabola = 1.0f - 4.0f * (progress - 0.5f) * (progress - 0.5f);

        Vector3 nextPos = Vector3.Lerp(_startPosition, vectorFinal, progress);

        nextPos.y += parabola * angle;

        transform.LookAt(nextPos, transform.forward);
        transform.position = nextPos;
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);

    }

    public void checkFinalPosition() {

        if (progress == 1.0f)
        {
            if (lastBounce)
            {
                SoundManager.PlaySound("meta");
                GameManager.RocksScore++;
                Destroy(gameObject);
            }
            else
            {
                if (!floorTouched)
                {

                    SoundManager.PlaySound("fall");
                    floorTouched = true;
                    Destroy(gameObject, 2.0f);
                }
            }
        }
    }

    public void checkCollisionWithBox() {

        if (gameObject.GetComponent<CircleCollider2D>().IsTouching(box.GetComponent<BoxCollider2D>()))
        {
            if (canInstantiate)
            {

                SoundManager.PlaySound("bounce");
                touch = true;
                if (GameObject.FindWithTag("Player").transform.position.x > 5f)
                {
                    lastBounce = true;
                }
                isBouncing = true;
                Instantiate(gameObject, transform.position, Quaternion.identity);
                Destroy(gameObject);

            }
        }

    }




}