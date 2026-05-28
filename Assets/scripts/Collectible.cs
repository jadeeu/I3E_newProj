using UnityEngine;

public class Collectible : MonoBehaviour
{
    // This triggers automatically when something enters the collider
    public void OnTriggerEnter(Collider other)
    {
        // Check if the object that touched us has the "Player" tag
        if (other.CompareTag("Player"))
        {
            CollectItem();
        }
    }

    public void CollectItem()
    {
        // 1. Add your logic here (e.g., increase score, add to inventory)
        Debug.Log("Item Collected!");

        // 2. Remove the item from the game world
        Destroy(gameObject);
    }
}