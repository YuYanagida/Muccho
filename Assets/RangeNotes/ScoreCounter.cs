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
        Debug.Log("�J�E���g������");

    }

    public void TotalScore()
    {
       // clearcamvas.SetActive(true);

        if (score < 3)
        {
            Debug.Log("��܂��̃Z���t�ł�");

            // bad.PlayOneShot(Bad[Random.Range(0, 1)]);

            resultB.SetActive(true);


        }

        else if (score >= 3 && score < 5)
        {
            Debug.Log("��܂��̃Z���t�ł�");

            resultBB.SetActive(true);
        }

        else if (score >= 5 && score < 15)
        {
            Debug.Log("���������̃Z���t�ł�");

            resultA.SetActive(true);
        }

        else if (score >= 15 && score < 20)
        {
            Debug.Log("���������̃Z���t�ł�");

            resultAA.SetActive(true);
        }


        else if (score >= 20 && score < 40)
        {
            Debug.Log("�J�߂�̃Z���t�ł�");

            resultS.SetActive(true);
        }

        else if (score >= 40)
        {
            Debug.Log("�J�߂�̃Z���t�ł�");

            resultSS.SetActive(true);
        }

    }

}

