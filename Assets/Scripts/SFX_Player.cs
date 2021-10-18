using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SFX_Player : MonoBehaviour
{
    public AudioClip errorSFX;
    public AudioClip unlockSFX;

    private void enterRoom()
    {
        GameObject player = GameObject.Find("Player");
        Ray_Shooter rayShooter = player.GetComponent<Ray_Shooter>();

        if (rayShooter.type == "VOLUNTEER")
        {

            SceneManager.LoadScene("Indoor");
        }
        else if (rayShooter.type == "MED")
        {
            SceneManager.LoadScene("Med Indoor");
        }

    }

    public void play(bool unlocked)
    {
        AudioSource audioSrc = this.GetComponent<AudioSource>();

        if (!unlocked)
        {
            audioSrc.clip = errorSFX;
        }
        else
        {
            audioSrc.clip = unlockSFX;
            Invoke("enterRoom", 2f);
        }

        audioSrc.Play();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
