using UnityEngine;

public class Goal : MonoBehaviour
{
    private int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            score++;
            Debug.Log("Score: " + score);
        }
    }
}