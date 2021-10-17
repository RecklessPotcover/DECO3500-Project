using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Framerate_Limiter : MonoBehaviour
{
    private void Awake()
    {
        QualitySettings.vSyncCount = 0; // Disable Vsync
        Application.targetFrameRate = 60; // Force unity run at 60 FPS
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
