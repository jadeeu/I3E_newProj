using UnityEngine;

public class GiftBox : MonoBehaviour
{
    public GameObject ballPrefab;

    private bool playerNear = false;
    private int pressCount = 0;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            pressCount++;
            Debug.Log("E Press Count: " + pressCount);

            if (pressCount >= 3)
            {
                // Spawn the ball slightly above the GiftBox
                Instantiate(ballPrefab, transform.position + Vector3.up, Quaternion.identity);

                // Destroy the GiftBox
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            Debug.Log("Player Near!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
            Debug.Log("Player Left!");
        }
    }
}
