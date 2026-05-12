using UnityEngine;

public class trigger : MonoBehaviour
{
    public collect playerCollect;   // reference to your collect script
    public int totalCollectibles = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerCollect.collectedItems >= totalCollectibles)
            {
                Debug.Log("All collectibles collected! Level Complete!");
            }
            else
            {
                Debug.Log("You still need to collect more items!");
            }
        }
    }
}
