using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour
{
    public void loadElderly()
    {

    }

    public void loadVolunteer()
    {
        SceneManager.LoadScene("Outdoor");
    }

    public void loadMedicalStaff()
    {

    }
}
