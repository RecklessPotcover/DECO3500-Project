using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elderly_Fall_Point : MonoBehaviour
{
    public float effectiveDistance;
    private bool isFell = false;
    private bool isEnd = false;

    private bool isFalling;
    private float timeCount = 0.0f;

    private float calculateDistanceToPlayer()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 playerPosition = player.GetComponent<Transform>().position;
        Vector3 fallPointPosition = this.GetComponent<Transform>().position;

        return Vector3.Distance(playerPosition, fallPointPosition);
    }

    private void end()
    {
        GameObject endCanvas = GameObject.Find("End Canvas");
        endCanvas.GetComponent<Canvas>().enabled = true;

        GameObject handler = GameObject.Find("Run Environment Handler");
        Cursor_Locker cursorLocker = handler.GetComponent<Cursor_Locker>();

        cursorLocker.setCursorLocked(false);

        isEnd = true;
    }

    private void fall()
    {
        GameObject player = GameObject.Find("Player");
        Transform playerTransform = player.GetComponent<Transform>();

        // Rotate the player
        Quaternion target = Quaternion.Euler(-90, 0, 0);
        playerTransform.rotation = Quaternion.Slerp(playerTransform.rotation, target, timeCount);
        timeCount = timeCount + Time.deltaTime / 2;

        if (playerTransform.rotation == target)
        {
            isFell = true;

            Player_Controller playerController = player.GetComponent<Player_Controller>();

            // Disable the player controller
            playerController.canMove = false;
            playerController.walkingSpeed = 0;
            playerController.runningSpeed = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isFalling = false;
        isFell = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = calculateDistanceToPlayer();

        if (distance <= effectiveDistance && !isFalling)
        {
            isFalling = true;
        }

        if (isFalling && !isFell)
        {
            fall();
        }

        if (isFell && !isEnd)
        {
            // Show end screen after 2 seconds
            Invoke("end", 2);
        }
    }
}
