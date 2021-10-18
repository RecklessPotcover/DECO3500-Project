using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_Locker : MonoBehaviour
{
    public bool cursorIsLocked = true;

    public void setCursorLocked(bool locked)
    {
        cursorIsLocked = locked;
        Cursor.visible = !locked;

        if (locked)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Cursor lock mode set to locked by default
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        cursorIsLocked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            setCursorLocked(!cursorIsLocked);
        }
    }
}
