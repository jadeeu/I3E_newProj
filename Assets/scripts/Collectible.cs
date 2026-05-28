using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Add this line so PlayerScript can read how much this item is worth
    public int score = 10; 

    // 1. From Slides: Create an AudioSource variable
    AudioSource collectibleAudio;

    void Start()
    {
        // 2. From Slides: Get the AudioSource component and store it
        collectibleAudio = GetComponent<AudioSource>();
    }

    public void CollectItem()
    {
        Debug.Log("Item Collected!");

        // 3. From Slides: Check if we have an AudioSource component, then play it
        if (collectibleAudio != null)
        {
            collectibleAudio.Play();
        }
        else
        {
            print("Warning: No AudioSource found on " + gameObject.name);
        }

        // 4. Hide the item immediately so it looks collected while the sound plays
        GetComponent<Collider>().enabled = false;
        if (GetComponent<Renderer>() != null) 
        {
            GetComponent<Renderer>().enabled = false;
        }

        // 5. Safely delete the object after 1 second so the audio has time to finish
        Destroy(gameObject, 1f);
    }
}