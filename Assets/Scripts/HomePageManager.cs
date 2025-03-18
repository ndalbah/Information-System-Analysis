using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

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

    public void OnExitGame(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
                        Debug.Log(this.name + " : " + this.GetType() + " : " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            #endif

            #if (UNITY_EDITOR)
                        UnityEditor.EditorApplication.isPlaying = false;
            #elif (UNITY_STANDALONE)
                                            Application.Quit();
            #elif (UNITY_WEBGL)
                                            SceneManager.LoadScene("QuitScene");

            #endif
        }
    }
}