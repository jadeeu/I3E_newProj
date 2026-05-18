using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int score = 10;

    public void Collect()
    {
        Debug.Log("Collected item worth: " + score);
        Destroy(gameObject);
    }
}