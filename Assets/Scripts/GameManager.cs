using UnityEngine;
using TMPro; // nécessaire pour TextMeshPro
using UnityEngine.SceneManagement; // pour recharger la scène

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Start()
    {
        UpdateScore();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Respawn"))
        {
            score++;
            UpdateScore();
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0); // recharge la première scène
        Time.timeScale = 1;
    }
}
