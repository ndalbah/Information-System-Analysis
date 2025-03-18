using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Splines;

public class WinDoorManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(7);
    }
}
