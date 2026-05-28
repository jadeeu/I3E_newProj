using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float collectDistance = 5f;

    int totalScore = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryCollect();
        }
    }

    void TryCollect()
    {
        Ray ray = Camera.main.ScreenPointToRay(
            new Vector3(Screen.width / 2, Screen.height / 2)
        );

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, collectDistance))
{
    // Change 'Collect' to 'Collectible' here
    Collectible collect = hit.collider.GetComponent<Collectible>();

    if (collect != null)
    {
        // If your Collectible script doesn't have a 'score' variable yet,
        // comment this next line out by adding // in front of it
        totalScore += collect.score; 

        collect.CollectItem();

        Debug.Log("Total Score: " + totalScore);
    }
}
    }
}