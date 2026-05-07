using UnityEngine;

public class collisions : MonoBehaviour
{
void OnCollisionEnter(Collision collision)
{
    print("Collied detected with" + collision.gameObject.name);
    if(collision.gameObject.name == "Plane")
        {
            Destroy(gameObject);
        }
}
void OnCollisionExit(Collision collision)
{ 
    print("Collison ended with" + collision.gameObject.name);
    Destroy(gameObject);
}
void OnCollisonStay(Collision collision)
    {
        print("Colliding ended with" + collision.gameObject.name);
    }
}