  using UnityEngine;

public class MyFirstScirpt : MonoBehaviour
{
  public float speed = 5f;
    public float limit = 5f;

    Vector3 direction = Vector3.right; // move along X
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = newPosition;
        print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
       // Move continuously
        transform.position += direction * speed * Time.deltaTime;

        // Check if beyond limit
        if (transform.position.x > limit || transform.position.x < -limit)
        {
            direction = -direction; // reverse direction
    }
  }
}