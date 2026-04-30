  using UnityEngine;

public class MyFirstScirpt : MonoBehaviour
{
      public float speed = 5f;
    public float rotateSpeed = 100f;
    public float limit = 5f;

    Vector3 direction = Vector3.right;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
  {
     // movement
        transform.position += direction * speed * Time.deltaTime;

        // rotation
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

        // reverse movement at limit
        if (transform.position.x > limit || transform.position.x < -limit)
        {
            direction = -direction;
   }
  }
}