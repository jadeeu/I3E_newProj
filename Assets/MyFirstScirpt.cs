  using UnityEngine;

public class MyFirstScirpt : MonoBehaviour
{
    public float speed = 100f;
    public float maxAngle = 45f;

    float currentRotation = 0f;
    float direction = 1f;

    Vector3 direction = Vector3.right;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
  {
            // rotate
        float rotationThisFrame = speed * Time.deltaTime * direction;
        transform.Rotate(0, rotationThisFrame, 0);

        currentRotation += rotationThisFrame;

        // reverse direction at limit
        if (currentRotation > maxAngle || currentRotation < -maxAngle)
        {
            direction = -direction;
   }
  }
}