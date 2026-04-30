  using UnityEngine;

public class MyFirstScirpt : MonoBehaviour
{
     Vector3 newPosition = new Vector3(1.0f,2.0f,3.0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = newPosition;
        print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(5f, 0f, 0f) * Time.deltaTime;
    }
}
