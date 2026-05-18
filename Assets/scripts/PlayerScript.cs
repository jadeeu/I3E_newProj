using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject currentCollectable;
    [SerializeField] private float interactDistance = 5f;
    [SerializeField] private LayerMask collectibleLayer;
private int currentScore = 0;

    int collCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            currentCollectable = collision.gameObject;
        }
    }

    void OnInteract()
    {
        if (currentCollectable)
        {
            collCount++;
            print("Player has collected " + collCount + " Collectibles");
            Destroy(currentCollectable);
        }
    }

[cite_start]public void OnInteract() // This automatically matches your 'Interact' Action [cite: 114, 127]
{
    RaycastHit hit;
    [cite_start]// Shoots a ray forward from the camera [cite: 135]
    if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, interactDistance, collectibleLayer))
    {
        [cite_start]// Look for your 'Collect' script on the object we hit [cite: 141]
        Collect collectibleItem = hit.collider.GetComponent<Collect>();
        if (collectibleItem != null)
        {
            [cite_start]// Get its unique score, add it, and destroy the object [cite: 142]
            currentScore += collectibleItem.GetScoreValue();
            Debug.Log("Current Score: " + currentScore);
            Destroy(hit.collider.gameObject);
        }
    }
}
}