

using UnityEngine;
using TMPro;

public class BallCode : MonoBehaviour

{
    public TextMeshProUGUI scoreText;
    int score = 0;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(200, -200));

        scoreText.text = "Score: 0";
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Brick"))
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = "Score: " + score;
        }
    }
}
