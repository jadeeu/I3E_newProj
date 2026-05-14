using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject currentCollectable;

    int collCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectible")
        {
            currentCollectable = collision.gameObject;
        }
    }

    void OnInteract()
    {
        collCount++;
        print("Player has collected" + collCount + "collectibles");
        Destroy(currentCollectable);
    }

}
