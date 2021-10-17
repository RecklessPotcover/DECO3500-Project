// The ray shooter is inspired by https://www.youtube.com/watch?v=fQTaJIUFI0A
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_Shooter : MonoBehaviour
{
    public float shootInterval;
    public bool isIndoor;

    new Camera camera;

    private float timer;
    public bool isCalling;

    void Start()
    {
        // Find the 'Main Camera' game object
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void Update()
    {
        if (isIndoor)
        {
            isCalling = GameObject.Find("Interactive Objects").GetComponent<Object_Controller>().isCalling;
        }

        // When click the left button of the mouse
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Shoot a ray from the center of the camera
            Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f));

            // If the ray hit a game object
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Log output the object's name
                GameObject hittenObject = hit.collider.gameObject;

                Debug.Log(hittenObject.name);

                // Outdoor interactions
                try
                {
                    hittenObject.GetComponent<Lock_Key>().click();
                }
                catch
                {

                }

                if (isIndoor && isCalling)
                {
                    // Indoor interactions
                    GameObject objects = GameObject.Find("Interactive Objects");
                    Object_Controller objController = objects.GetComponent<Object_Controller>();

                    if (hittenObject.name == "Pillow on Sofa")
                    {
                        objController.takeFromSofa("Pillow");
                    }

                    if (hittenObject.name == "Pillow Area" && objController.isPillowTaken)
                    {
                        objController.put("Pillow");
                    }

                    if (hittenObject.name == "Blanket on Sofa" && objController.isPillowPut)
                    {
                        objController.takeFromSofa("Blanket");
                    }

                    if (hittenObject.name == "Blanket Area" && objController.isPillowPut && objController.isBlanketTaken)
                    {
                        objController.put("Blanket");
                    }
                }
            }
        }

        if (timer >= shootInterval && isIndoor && isCalling)
        {
            // Shoot a ray from the center of the camera
            Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject hittenObject = hit.collider.gameObject;
                string objName = hittenObject.name;

                GameObject aimInfo = GameObject.Find("Aim Information");
                Aim_Info_Controller infoController = aimInfo.GetComponent<Aim_Info_Controller>();


                GameObject objects = GameObject.Find("Interactive Objects");
                Object_Controller objController = objects.GetComponent<Object_Controller>();

                if (objName == "Pillow on Sofa")
                {
                    infoController.setText("[Left Mouse Button] Pick up pillow");
                }
                else if (objName == "Blanket on Sofa")
                {
                    if (objController.isPillowPut)
                    {
                        infoController.setText("[Left Mouse Button] Pick up Blanket");
                    }
                }
                else if (objName == "Pillow Area")
                {
                    if (objController.isPillowTaken)
                    {
                        infoController.setText("[Left Mouse Button] Put pillow");
                    }
                }
                else if (objName == "Blanket Area")
                {
                    if (objController.isPillowPut && objController.isBlanketTaken)
                    {
                        infoController.setText("[Left Mouse Button] Put Blanket");
                    }
                }
                else
                {
                    infoController.setText("");
                }
            }
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
