using UnityEngine;

public class Collect : MonoBehaviour
{
    public int score = 10;

    AudioSource collectibleAuto;

    public void CollectItem()
    {
        Debug.Log("Collected item worth: " + score);
        Destroy(gameObject);
    }

    void Start()
    {
        collectibleAudio = Getcomponent<AudioSource>();
    }
}