using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class SettingsManager : MonoBehaviour 
{
    MusicPlayer musicPlayer;
    public void OnBack()
    {
        SceneManager.LoadScene(1);
    }

    public void OnTutorial()
    {
        SceneManager.LoadScene(4);
    }

    public void OnMuteBackgroundMusic()
    {
        musicPlayer.introSource.mute = true;
        musicPlayer.loopSource.mute = true;
    }

    public bool OnToggleValueChanged()
    {
        return true;
    }
}
