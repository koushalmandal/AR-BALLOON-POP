using UnityEngine;

public class BalloonPop : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore();
        }

        Destroy(gameObject);
    }
}