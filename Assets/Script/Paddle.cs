using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    private int speed,score;

    public Text scoreText;

    public float rightBarrier,leftBarrier;

    // Update is called once per frame
    void Update()
    {
        MovementPaddle();
        
    }

    private void MovementPaddle()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
        if (transform.position.x < leftBarrier)
        {
            transform.position = new Vector2(leftBarrier, transform.position.y);
        }
        if (transform.position.x > rightBarrier)
        {
            transform.position = new Vector2(rightBarrier, transform.position.y);

        }
    }


    private void OnCollisionEnter(Collision coll)
    {
        score++;
        scoreText.text = score.ToString();
    }
}
