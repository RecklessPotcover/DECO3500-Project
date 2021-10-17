using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation_Controller : MonoBehaviour
{
    public float expireDistance;
    public float calculateInterval;

    private GameObject player;
    private GameObject terminal;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        terminal = GameObject.Find("Terminal");
    }

    private bool isExpired()
    {
        Vector3 playerPosition = player.GetComponent<Transform>().position;
        Vector3 terminalPosition = terminal.GetComponent<Transform>().position;

        float distance = Vector3.Distance(playerPosition, terminalPosition);

        return distance >= expireDistance;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= calculateInterval)
        {
            GameObject nav = GameObject.Find("Navigation");

            nav.SetActive(isExpired());

            timer = 0f;// Reset timer

            GetComponent<Navigation_Controller>().enabled = isExpired();// Disable script
        }
    }
}
