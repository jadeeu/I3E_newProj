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
            Collectible collectible =
                hit.collider.GetComponent<Collectible>();

            if (collectible != null)
            {
                totalScore += collectible.score;

                collectible.Collect();

                Debug.Log("Total Score: " + totalScore);
            }
        }
    }
}