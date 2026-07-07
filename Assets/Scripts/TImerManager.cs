using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public float timeLeft = 20f;

    public TMP_Text timerText;
    public TMP_Text finalScoreText;
    public TMP_Text scoreText;

    public GameObject gameOverPanel;
    public BalloonSpawner balloonSpawner;

    private bool gameEnded = false;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (gameEnded)
            return;

        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
            timeLeft = 0;

        timerText.text = "Time : " + Mathf.CeilToInt(timeLeft);

        if (timeLeft <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;

        // Stop spawning balloons
        balloonSpawner.enabled = false;

        // Hide Score and Timer
        scoreText.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);

        // Show Game Over Panel
        gameOverPanel.SetActive(true);

        // Show Final Score
        finalScoreText.text = "Final Score : " + ScoreManager.score;
    }
}