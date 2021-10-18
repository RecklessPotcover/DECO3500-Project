using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Med_Controller : MonoBehaviour
{
    private bool rescueCompleted;
    private bool isActing;
    private bool isEnd;
    private float timer;

    private void act()
    {
        Vector3 medPosition = this.GetComponent<Transform>().position;

        GameObject terminal = GameObject.Find("Med Terminal");
        Vector3 terminalPosition = terminal.GetComponent<Transform>().position;

        this.GetComponent<Transform>().position = Vector3.MoveTowards(medPosition, terminalPosition, timer);
        timer += Time.deltaTime / 20;

        if (medPosition == terminalPosition && !isEnd)
        {
            Invoke("end", 2);
        }
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

    // Start is called before the first frame update
    void Start()
    {
        isActing = false;
        isEnd = false;
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject objs = GameObject.Find("Interactive Objects");
        Object_Controller objController = objs.GetComponent<Object_Controller>();

        rescueCompleted = objController.isBlanketPut;

        if (rescueCompleted && !isActing)
        {
            Invoke("act", 2);
        }
    }
}
