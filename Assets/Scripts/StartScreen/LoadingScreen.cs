using System.Net.Http;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{

    public Slider bar;
    private float overallProgress = 0;

    // Start is called before the first frame update
    void Start()
    {
        bar.value = 0;
        overallProgress = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        overallProgress += 0.0001f;

        bar.value = overallProgress;

        if(bar.value == 1) {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
