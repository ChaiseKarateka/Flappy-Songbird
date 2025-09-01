using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    public GameObject restartButton;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Game Over !");
        restartButton.SetActive(true);
        Time.timeScale = 0; // stoppe le jeu
    }

}
