using UnityEngine;

public class Collect : MonoBehaviour
{
    public int score = 10;


    public void CollectItem()
    {
        Debug.Log("Collected item worth: " + score);
        Destroy(gameObject);
    }
}