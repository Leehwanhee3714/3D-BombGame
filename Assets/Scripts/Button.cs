using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //중요

public class Button : MonoBehaviour
{
    public void Reset()
    {
        SceneManager.LoadScene("SampleScnene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
