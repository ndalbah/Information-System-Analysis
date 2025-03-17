using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ProfileManager : MonoBehaviour
{
    public void OnBack()
    {
        SceneManager.LoadScene(1);
    }

    public void OnSignout()
    {
        SceneManager.LoadScene(0);
    }
}
