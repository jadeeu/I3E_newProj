using UnityEngine;

public class collect : MonoBehaviour
{
    public int collectedItems = 0;
    public int totalCollectibles = 5
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            collectedItems++;
            Destroy(collision.gameObject);

            Debug.Log("Collected: " + collectedItems);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishZone"))
        {
            if (collectedItems >= totalCollectibles)
            {
                Debug.Log("ALL COLLECTED! LEVEL COMPLETE!");
            }
            else
            {
                Debug.Log("Not all collectibles collected yet!");
            }
        }
    }
}
