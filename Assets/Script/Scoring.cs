using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scoring : MonoBehaviour
{

    [SerializeField]
    private GameObject losePopup,scoreDisplay;

    private int score,lifePlayer;
    public Text scoreText;


    private void Start()
    {
        lifePlayer = 3;
    }

    private void Update()
    {
        
    }

    public void ScorePlayer()
    {
        score++;
        scoreText.text = score.ToString();
        Debug.Log("Score Berhasil");
    }

    public void LifePlayer()
    {
        lifePlayer--;
        Debug.Log("Life Berkurang");
    }

    void ScoreFinal()
    {

    }


    private void OnTriggerEnter(Collider ball)
    {
       if(lifePlayer > 0)
        {
            if (ball.gameObject.tag == "Ball")
            {
                LifePlayer();
            }
        }else
        {
            losePopup.SetActive(true);
            scoreDisplay.SetActive(false);


        }
    }
}
