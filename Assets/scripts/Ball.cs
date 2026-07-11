using UnityEngine;

public class Ball : MonoBehaviour
{
    public float forceAmount = 200f;
    public float interactDistance = 3f;

    private Rigidbody rb;
    private Transform player;
    private bool launched = false;

    void Start()
    {
        // Get the Rigidbody attached to the Ball
        rb = GetComponent<Rigidbody>();

        // Find the Player automatically
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");

        if (playerObj != null)
        {
            player = playerObj.transform;
            Debug.Log("Player assigned!");
        }
        else
        {
            Debug.LogError("Player not found!");
        }
    }

    void Update()
    {
        // Stop if the player wasn't found
        if (player == null)
            return;

        // Check if the player is close enough to the Ball
        if (Vector3.Distance(transform.position, player.position) <= interactDistance)
        {
            // Press E to kick the Ball
            if (Input.GetKeyDown(KeyCode.E) && !launched)
            {
                rb.AddForce(player.forward * forceAmount);

                launched = true;

                Debug.Log("Ball Launched!");
            }
        }
    }
}