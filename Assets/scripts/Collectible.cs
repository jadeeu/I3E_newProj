using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Add this line so PlayerScript can read how much this item is worth
    public int score = 10; 

    public void CollectItem()
    {
        Debug.Log("Item Collected!");
        Destroy(gameObject);
    }
}