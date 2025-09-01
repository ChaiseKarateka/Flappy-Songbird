using UnityEngine;
using TMPro; // n�cessaire pour TextMeshPro
using UnityEngine.SceneManagement; // pour recharger la sc�ne

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
        SceneManager.LoadScene(0); // recharge la premi�re sc�ne
        Time.timeScale = 1;
    }
}
