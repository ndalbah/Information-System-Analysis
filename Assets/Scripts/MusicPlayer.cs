using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource introSource, loopSource;
    private static MusicPlayer instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        bool isMusicOn = PlayerPrefs.GetInt("MusicEnabled", 1) == 1;
        introSource.mute = !isMusicOn;
        loopSource.mute = !isMusicOn;

        introSource.Play();
        loopSource.PlayScheduled(AudioSettings.dspTime + introSource.clip.length);
    }

    public void ToggleMusic(bool isOn)
    {
        introSource.mute = !isOn;
        loopSource.mute = !isOn;

        PlayerPrefs.SetInt("MusicEnabled", isOn ? 1 : 0);
        PlayerPrefs.Save();
    }
}
