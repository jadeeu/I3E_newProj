using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
