using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;

    void Start()
    {
        // Automatically grabs the Animator attached to this door
        animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        // Toggles the state back and forth (true/false)
        isOpen = !isOpen;

        // Tells your Animator state machine to switch between DoorOpen and doorClose
        if (animator != null)
        {
            animator.SetBool("isOpen", isOpen);
        }
    }
}