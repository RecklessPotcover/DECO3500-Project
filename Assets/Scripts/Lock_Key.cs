using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_Key : MonoBehaviour
{
    public string keyName;
    public string type;

    public void click()
    {
        GameObject lockObj = GameObject.Find("Password Lock");
        Password_Lock pswLock = lockObj.GetComponent<Password_Lock>();

        if (type == "NUMBER")
        {
            pswLock.add(keyName);
        }
        else if (type == "DELETE")
        {
            pswLock.delete();
        }
        else if (type == "CLEAR")
        {
            pswLock.clear();
        }
        else if (type == "CONFIRM")
        {
            if (pswLock.verifyPassword())
            {
                lockObj.GetComponent<SFX_Player>().play(true);
            }
            else
            {
                lockObj.GetComponent<SFX_Player>().play(false);
                pswLock.clear();
            }
        }

        GameObject.Find("Screen Output").GetComponent<TextMesh>().text = pswLock.display();
    }

    // Start is called before the first frame update
    void Start()
    {
        TextMesh name = GetComponentInChildren<TextMesh>();
        name.text = keyName;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
