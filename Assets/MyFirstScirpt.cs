  using UnityEngine;

public class MyFirstScirpt : MonoBehaviour
{
    public float speed = 2f;
    public float maxAngle = 45f;

    Vector3 direction = Vector3.right;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Sin(Time.time * speed) * maxAngle;
        transform.eulerAngles = new Vector3(0, angle, 0);
    }
}