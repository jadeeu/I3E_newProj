using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject currentCollectable;

    int collCount = 0;

    void OnTriggerEnter(Collider collision)
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
            print("Player has collected " + collCount + " collectibles");
            Destroy(currentCollectable);
        }
    }
}