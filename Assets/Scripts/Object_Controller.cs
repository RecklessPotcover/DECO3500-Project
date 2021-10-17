using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Controller : MonoBehaviour
{
    public bool isPillowTaken = false;
    public bool isPillowPut = false;
    public bool isBlanketTaken = false;
    public bool isBlanketPut = false;
    public bool isCalling = false;

    private Task_Controller taskController;

    private void removeVomit()
    {
        GameObject vomit = GameObject.Find("Vomit");
        vomit.SetActive(false);
    }

    public void takeFromSofa(string objectName)
    {
        GameObject objectOnSofa = GameObject.Find(objectName + " on Sofa");
        GameObject putArea = GameObject.Find(objectName + " Area");

        putArea.GetComponent<MeshRenderer>().enabled = true;
        objectOnSofa.SetActive(false);

        if (objectName == "Pillow")
        {
            isPillowTaken = true;
        }
        else if (objectName == "Blanket")
        {
            isBlanketTaken = true;
        }
    }

    public void put(string objectName)
    {
        GameObject targetObject = GameObject.Find(objectName);
        GameObject objectArea = GameObject.Find(objectName + " Area");

        if (objectName == "Pillow")
        {
            targetObject.GetComponent<MeshRenderer>().enabled = true;

            GameObject elderlyNeck = GameObject.Find("LowManNeck");
            elderlyNeck.GetComponent<Transform>().Rotate(0, 0, -50);

            isPillowPut = true;

            removeVomit();
        }
        else if (objectName == "Blanket")
        {
            isBlanketPut = true;

            for (int i = 1; i <= 5; i++)
            {
                GameObject blanketPiece = GameObject.Find("Blanket " + i);

                blanketPiece.GetComponent<MeshRenderer>().enabled = true;
            }
        }

        objectArea.SetActive(false);
    }

    private void Start()
    {
        taskController = GameObject.Find("Task Information").GetComponent<Task_Controller>();
    }

    private void Update()
    {
        if (isBlanketPut)
        {
            taskController.setTask("Wait for the medical staff to arrive");
        }
        else if (isBlanketTaken)
        {
            taskController.setTask("Cover the elderly with the blanket");
        }
        else if (isPillowPut)
        {
            taskController.setTask("Find a blanket");
        }
        else if (isPillowTaken)
        {
            taskController.setTask("Put the pillow under the elderly's head and turn his face to the side");
        }
        else if (isCalling)
        {
            taskController.setTask("Find a pillow");
        }
        else
        {
            taskController.setTask("You have never meet this situation before. Call the medical staff!");
        }

    }
}
