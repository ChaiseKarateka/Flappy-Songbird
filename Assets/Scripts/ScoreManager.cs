using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("pipe"))
        {
            score++;
        }
    }
}
