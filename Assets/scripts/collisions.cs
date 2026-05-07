using UnityEngine;

public class collisions : MonoBehaviour
{
void OnCollisionEnter(Collision collision)
{
    print("Collied detected with" + collision.gameObject.name);
}
void OnCollisionExit(Collision collision)
{ 
    print("Collison ended with" + collision.gameObject.name)
}
}
