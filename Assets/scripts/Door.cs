using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false; // This tracks the state inside the script

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        isOpen = !isOpen;

        if (animator != null)
        {
            // CHANGED: "isOpen" is now changed to "openDoor" to match your Animator parameter
            animator.SetBool("openDoor", isOpen);
        }
    }
}