using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Splines;

public class WinManager : MonoBehaviour
{
    public void OnHome()
    {
        SceneManager.LoadScene(1);
    }

    public void OnNext()
    {
        SceneManager.LoadScene(9);
    }
}
