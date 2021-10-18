using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour
{
    public void loadMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void loadElderly()
    {
        SceneManager.LoadScene("Elderly");
    }

    public void loadVolunteer()
    {
        SceneManager.LoadScene("Outdoor");
    }

    public void loadMedicalStaff()
    {
        SceneManager.LoadScene("Med Outdoor");
    }

    public void quitApplication()
    {
        Application.Quit();
    }
}
