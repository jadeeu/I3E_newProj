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
        ballScript.player = GameObject.Find("PlayerCapsule").transform;
    }
}