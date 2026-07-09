using UnityEngine;

public class GiftBox : MonoBehaviour
{
    public GameObject ballPrefab;

    private bool playerNear = false;
    private int pressCount = 0;

    void Update()
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        Debug.Log("E Pressed");
    }
}
}
