using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    private MusicPlayer musicPlayer;
    public Toggle musicToggle;
    public Toggle soundEffectsToggle;

    private void Start()
    {
        musicPlayer = FindObjectOfType<MusicPlayer>();

        bool isMusicOn = PlayerPrefs.GetInt("MusicEnabled", 1) == 1;
        bool isSoundEffectsOn = PlayerPrefs.GetInt("SoundEffectsEnabled", 1) == 1;

        musicToggle.isOn = isMusicOn;
        soundEffectsToggle.isOn = isSoundEffectsOn;

        musicToggle.onValueChanged.AddListener(ToggleMusic);
        soundEffectsToggle.onValueChanged.AddListener(ToggleSoundEffects);
    }

    public void OnBack()
    {
        SceneManager.LoadScene(1);
    }

    public void OnTutorial()
    {
        SceneManager.LoadScene(4);
    }

    private void ToggleMusic(bool isOn)
    {
        if (musicPlayer != null)
        {
            musicPlayer.ToggleMusic(isOn);
        }

        PlayerPrefs.SetInt("MusicEnabled", isOn ? 1 : 0);
        PlayerPrefs.Save();
    }

    private void ToggleSoundEffects(bool isOn)
    {
        PlayerPrefs.SetInt("SoundEffectsEnabled", isOn ? 1 : 0);
        PlayerPrefs.Save();
    }
}
