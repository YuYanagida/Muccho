using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScoreCounter : MonoBehaviour
{
    public static int score;
    /*public Text scoreDisplay;
    public AudioSource bad;
    public AudioSource good;
    public AudioSource great;
    public AudioClip[] Bad;
    public AudioClip[] Good;
    public AudioClip[] Great;
    public GameObject clearcamvas;*/
    public GameObject resultB;
    public GameObject resultBB;
    public GameObject resultA;
    public GameObject resultAA;
    public GameObject resultS;
    public GameObject resultSS;

    public static void AddScore(int point)
    {
        score += point;

        Debug.Log("score" + score);
        Debug.Log("カウントしたよ");

    }

    public void TotalScore()
    {
       // clearcamvas.SetActive(true);

        if (score < 3)
        {
            Debug.Log("励ましのセリフです");

            // bad.PlayOneShot(Bad[Random.Range(0, 1)]);

            resultB.SetActive(true);


        }

        else if (score >= 3 && score < 5)
        {
            Debug.Log("励ましのセリフです");

            resultBB.SetActive(true);
        }

        else if (score >= 5 && score < 15)
        {
            Debug.Log("いい感じのセリフです");

            resultA.SetActive(true);
        }

        else if (score >= 15 && score < 20)
        {
            Debug.Log("いい感じのセリフです");

            resultAA.SetActive(true);
        }


        else if (score >= 20 && score < 40)
        {
            Debug.Log("褒めるのセリフです");

            resultS.SetActive(true);
        }

        else if (score >= 40)
        {
            Debug.Log("褒めるのセリフです");

            resultSS.SetActive(true);
        }

    }

}

