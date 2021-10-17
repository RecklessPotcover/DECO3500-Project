using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aim_Info_Controller : MonoBehaviour
{
    public void setText(string information)
    {
        this.GetComponent<Text>().text = information;
    }
}
