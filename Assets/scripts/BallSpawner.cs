using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;

    void Start()
    {
        GameObject ball = Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);

        // Tell the ball who the player is
        Ball ballScript = ball.GetComponent<Ball>();
        GameObject playerObj = GameObject.Find("PlayerCapsule");

if (playerObj != null)
{
    ballScript.player = playerObj.transform;
    Debug.Log("Player assigned!");
}
else
{
    Debug.LogError("PlayerCapsule not found!");
}
    }
}