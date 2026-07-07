using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public static int score = 0;
    public TMP_Text scoreText;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        score = 0;
        scoreText.text = "Score : 0";
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score : " + score;
    }
}