using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreenManager : MonoBehaviour
{
    public void OnHome()
    {
        SceneManager.LoadScene(1);
    }

    public void OnRestart()
    {
        SceneManager.LoadScene(5);
        
    }
}
