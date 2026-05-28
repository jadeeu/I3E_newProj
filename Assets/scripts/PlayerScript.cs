using UnityEngine;
using UnityEngine.InputSystem; // Using the new input system namespace

public class PlayerScript : MonoBehaviour
{
    public float interactDistance = 5f; // Renamed to cover both doors and collectibles
    int totalScore = 0;

    void Update()
    {
        // Checks for the 'E' key using the New Input System
        if (Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            TryInteract();
        }
    }

    void TryInteract()
    {
        // Creates a ray pointing directly out from the center of the screen
        Ray ray = Camera.main.ScreenPointToRay(
            new Vector3(Screen.width / 2f, Screen.height / 2f, 0f)
        );

        RaycastHit hit;

        // Casts the ray into the scene
        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            // 1. First, check if the object we hit is a Collectible
            Collectible collect = hit.collider.GetComponent<Collectible>();
            if (collect != null)
            {
                totalScore += collect.score; 
                collect.CollectItem();
                Debug.Log("Total Score: " + totalScore);
                return; // Stop running this method since we successfully collected something
            }

            // 2. If it wasn't a collectible, check if it's a Door
            Door door = hit.collider.GetComponent<Door>();
            if (door != null)
            {
                door.Interact();
                Debug.Log("Interacted with Door!");
            }
        }
    }
}