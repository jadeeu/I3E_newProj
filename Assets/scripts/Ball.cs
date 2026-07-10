using UnityEngine;

public class Ball : MonoBehaviour
{
    public float forceAmount = 500f;
    public Transform player;
    public float interactDistance = 3f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if player is close enough
        if (Vector3.Distance(transform.position, player.position) <= interactDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
                Debug.Log("Ball Launched!");
            }
        }
    }
}