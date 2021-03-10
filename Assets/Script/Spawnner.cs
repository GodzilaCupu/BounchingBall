using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject ballGreen,ballRed,ballBlue;
    float xPos;
    float yPos;
    //private int ballCount;

    private void Start()
    {
        Invoke("StartSpawning", 1f);
    }

    public void StartSpawning()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        #region Opsi Pertama (singleColor)
        //while ( ballCount < 5)
        //{
        //    xPos = Random.Range(-17, 17);
        //    yPos = Random.Range(22, 55);
        //    Instantiate(ballGreen,new Vector3(xPos,yPos, 0),Quaternion.identity);
        //    yield return new WaitForSeconds(2.5f);
        //    ballCount++;
        //}
        #endregion

        #region Opsi Ke-2
        yield return new WaitForSeconds(Random.Range(0f, 5f));
        xPos = Random.Range(-17, 17);
        yPos = Random.Range(35, 55);

        int x = Random.Range(0, 10);

        if ( x >=6 )
        {
            Instantiate(ballRed, new Vector3(xPos, yPos, 0), Quaternion.identity);
            Debug.Log("merah");

        }else if (x >= 4 && x < 6)
        {
            Instantiate(ballGreen, new Vector3(xPos, yPos, 0), Quaternion.identity);
            Debug.Log("Hijau");

        }else
        {
            Instantiate(ballBlue, new Vector3(xPos, yPos, 0), Quaternion.identity);
            Debug.Log("Biru");

        }

        Invoke("StartSpawning", 0f);
        Debug.Log("Berhasil Invoke");

        #endregion
    }
}
