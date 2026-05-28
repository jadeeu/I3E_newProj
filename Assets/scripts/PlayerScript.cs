using UnityEngine;
using UnityEngine.InputSystem; // Using the new input system namespace

public class PlayerScript : MonoBehaviour
{
    public float collectDistance = 5f;
    int totalScore = 0;

    void Update()
    {
        // CHANGED: This checks for the 'E' key using the New Input System
        if (Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            TryCollect();
        }
    }

    void TryCollect()
    {
        // Creates a ray pointing directly out from the center of the screen
        Ray ray = Camera.main.ScreenPointToRay(
            new Vector3(Screen.width / 2f, Screen.height / 2f, 0f)
        );

        RaycastHit hit;

        // Casts the ray into the scene
        if (Physics.Raycast(ray, out hit, collectDistance))
        {
            Collectible collect = hit.collider.GetComponent<Collectible>();

            if (collect != null)
            {
                totalScore += collect.score; 
                collect.CollectItem();
                Debug.Log("Total Score: " + totalScore);
            }
        }
    }
}