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

            if (pressCount == 3)
            {
                Instantiate(ballPrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}