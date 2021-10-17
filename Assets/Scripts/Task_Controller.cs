using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task_Controller : MonoBehaviour
{
    public void setTask(string taskText)
    {
        this.GetComponent<Text>().text = taskText;
    }
}
