using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject currentCollectable;
    int collCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            currentCollectable = collision.gameObject;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            currentCollectable = null;
        }
    }

    // This gets called by Starter Assets Input System
    void OnInteract()
    {
        if (currentCollectable != null)
        {
            collCount++;
            print("Player has collected " + collCount + " collectibles");

            Destroy(currentCollectable);
            currentCollectable = null;
        }
    }
}
