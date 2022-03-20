using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public float timeRemaining;
    public static int RocksScore;
    public static int Score;

    public Text time, rocksS, scoreS;

    public Transform coin;

    private bool notCoin = true;

    public float spawnCollisionCheckRadius;

    public int rocksNecessary;

    public static bool Difficult;

    void Awake() {

        Application.targetFrameRate = 60;
        Screen.SetResolution(1360, 768, true);

    }

    void Start()
    {
        RocksScore = 0;
        Score = 0;
    }

    void Update()
    {

        timeSystem();
        spawnCoins();
        hudSystem();
    }

    private void timeSystem() {


        //Sistema de tiempo, al llegar a 0 se termina
        if (!GameOver.itsOver)
        {
            timeRemaining -= Time.deltaTime;
            int timeLeft = (int)timeRemaining;
            time.text = timeLeft.ToString();
            if (timeRemaining < 1)
            {
                GameOver.itsOver = true;
            }
        }
    }

    private void spawnCoins() {

        // Chequeo que el score sea distinto a 0 para que no spawnee una moneda.
        if (RocksScore != 0 && RocksScore % rocksNecessary == 0 && notCoin)
        {

            //La posicion en que puede spawnear una moneda
            float position = Random.Range(-5, 9);
            Vector3 spawnPoint = new Vector3(position, -4f, -9f);

            //Para que no spawnee una moneda en el mismo lugar donde se encuentra el heroe.
            if (!Physics2D.OverlapCircle(spawnPoint, spawnCollisionCheckRadius))
            {
                Instantiate(coin, spawnPoint, Quaternion.identity);
            }
            else //En el caso de que suceda que quiera spawnear en el mismo lugar del heroe, se invoca a la funcion de nuevo.
            {
                spawnCoins();

            }

            notCoin = false;

        }
        else if (RocksScore % rocksNecessary != 0)
        {

            notCoin = true;
        }


    }

    private void hudSystem() {
        //Actualizacion constante de HUD.
        rocksS.text = RocksScore.ToString();
        scoreS.text = Score.ToString();

    }

}
