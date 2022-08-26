using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int score;
    //public Text scoreDisplay;
    public AudioSource bad;
    public AudioSource good;
    public AudioSource great;
    public AudioClip[] Bad;
    public AudioClip[] Good;
    public AudioClip[] Great;
    public GameObject clearcamvas;

    public static void AddScore(int point)
    {
        score += point;

        Debug.Log("score " + score);

    }

    public void TotalScore()
    {
        clearcamvas.SetActive(true);

        if (score < 5)
        {
            Debug.Log("��܂��̃Z���t�ł�");

            bad.PlayOneShot(Bad[Random.Range(0, 1)]);
            

        }

        else if (score >= 5 && score < 20)
        {
            Debug.Log("���������̃Z���t�ł�");

            good.PlayOneShot(Good[Random.Range(0, 1)]);
        }

        else if (score >= 20)
        {
            Debug.Log("�J�߂�̃Z���t�ł�");

            great.PlayOneShot(Great[Random.Range(0, 1)]);
        }

    }

}

