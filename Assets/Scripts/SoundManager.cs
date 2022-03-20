using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip bounce, coin, throwRock, fall, meta;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        throwRock = Resources.Load<AudioClip>("Throw");
        bounce = Resources.Load<AudioClip>("Bounce");
        coin = Resources.Load<AudioClip>("Coin");
        fall = Resources.Load<AudioClip>("Floor");
        meta = Resources.Load<AudioClip>("Meta");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {


        switch (clip)
        {

            case "bounce":
                audioSrc.PlayOneShot(bounce);
                break;
            case "coin":

                audioSrc.PlayOneShot(coin);
                break;
            case "throw":
                audioSrc.PlayOneShot(throwRock);
                break;
            case "fall":
                audioSrc.PlayOneShot(fall);
                break;
            case "meta":
                audioSrc.PlayOneShot(meta);
                break;
        }
    }
}
