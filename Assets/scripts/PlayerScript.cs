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

    void OnInteract()
    {
        if (currentCollectable)
        {
            collCount++;
            print("Player has collected " + collCount + " Collectibles");
            Destroy(currentCollectable);
        }
    }
}