using UnityEngine;

public class Ball : MonoBehaviour
{
    public float forceAmount = 10f;
    public float interactDistance = 3f;

    private Rigidbody rb;
    private Transform player;
    private bool launched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Automatically find the player
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
        if (player == null)
            return;

        if (!launched &&
            Vector3.Distance(transform.position, player.position) <= interactDistance &&
            Input.GetKeyDown(KeyCode.E))
        {
            rb.AddForce(player.forward * forceAmount, ForceMode.Impulse);
            launched = true;
            Debug.Log("Ball Launched!");
        }
    }
}