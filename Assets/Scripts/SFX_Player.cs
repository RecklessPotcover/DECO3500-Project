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
        SceneManager.LoadScene("Indoor");
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
