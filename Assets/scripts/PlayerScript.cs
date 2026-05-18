using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject currentCollectable;

    int totalScore = 0;

    public float collectDistance = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnInteract();
        }
    }

    void OnInteract()
    {
        Ray ray = Camera.main.ScreenPointToRay(
            new Vector3(Screen.width / 2, Screen.height / 2)
        );

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, collectDistance))
        {
            if (hit.collider.CompareTag("Collectible"))
            {
                currentCollectable = hit.collider.gameObject;

                Collectible collectible =
                    currentCollectable.GetComponent<Collectible>();

                if (collectible != null)
                {
                    totalScore += collectible.score;

                    print("Collected! Total Score: " + totalScore);
                }

                Destroy(currentCollectable);
                currentCollectable = null;
            }
        }
    }
}