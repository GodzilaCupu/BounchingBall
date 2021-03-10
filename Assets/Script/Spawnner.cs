using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject ballGreen;
    int xPos;
    int yPos;
    private int ballCount;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while ( ballCount < 5)
        {
            xPos = Random.Range(-17, 17);
            yPos = Random.Range(22, 55);
            Instantiate(ballGreen,new Vector3(xPos,yPos, 0),Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
            ballCount++;
        }
    }
}
