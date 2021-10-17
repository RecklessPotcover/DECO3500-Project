using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_Locker : MonoBehaviour
{
    public bool cursorIsLocked = true;

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
            Cursor.visible = !Cursor.visible;

            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }

            cursorIsLocked = !Cursor.visible;
        }
    }
}
