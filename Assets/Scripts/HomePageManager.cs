using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HomePageManager : MonoBehaviour
{
    public void OnProfile()
    {
        SceneManager.LoadScene(2);
    }

    public void OnSettings()
    {
        SceneManager.LoadScene(3);
    }

    public void OnStart()
    {
        SceneManager.LoadScene(5);
    }
}