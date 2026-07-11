using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    private int score = 0;

    public TMP_Text scoreText;

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            score++;
            scoreText.text = "Score: " + score;

            Debug.Log("Score: " + score);

            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;      // Unity 6
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}