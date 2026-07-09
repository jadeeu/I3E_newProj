using UnityEngine;

public class GiftBox : MonoBehaviour
{
    public GameObject ballPrefab;

    void Update()
    {
        // Press G to destroy the GiftBox (for testing)
        if (Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(ballPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}