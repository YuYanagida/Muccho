using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int score;
    //public Text scoreDisplay;
    public AudioSource great;
    public AudioSource good;
    public AudioSource bad;

    public static void AddScore(int point)
    {
        score += point;

        Debug.Log("score " + score);

    }

    public void TotalScore()
    {
        if (score < 5)
        {
            Debug.Log("セリフです");

            //good.PlayOneShot();

        }

        else if (score <= 5)
        {
            Debug.Log("いい感じのセリフです");
        }

    }

}

