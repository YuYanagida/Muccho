using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int score;
    //public Text scoreDisplay;

    public static void AddScore(int point)
    {
        score += point;

        Debug.Log("score " + score);

    }

    public void TotalScore()
    {
        if (score < 5)
        {
            Debug.Log("�Z���t�ł�");
        }

        else if (score <= 5)
        {
            Debug.Log("���������̃Z���t�ł�");
        }

    }

}

