using UnityEngine;

public class PlayOneShotBehavior : StateMachineBehaviour
{
    public AudioClip soundToPlay;
    public float volume = 1f;
    public bool playOnEnter = true, playOnExit = false, playAfterDelay = false;

    // Delayed sound timer
    public float playDelay = 0.25f;
    private float timeSinceEntered = 0;
    private bool hasDelayedSoundPlayed = false;

    private bool IsSoundEffectsEnabled()
    {
        return PlayerPrefs.GetInt("SoundEffectsEnabled", 1) == 1;
    }

    private void PlaySound(Vector3 position)
    {
        if (IsSoundEffectsEnabled() && soundToPlay != null)
        {
            AudioSource.PlayClipAtPoint(soundToPlay, position, volume);
        }
    }

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (playOnEnter)
        {
            PlaySound(animator.gameObject.transform.position);
        }

        timeSinceEntered = 0;
        hasDelayedSoundPlayed = false;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (playAfterDelay && !hasDelayedSoundPlayed)
        {
            timeSinceEntered += Time.deltaTime;

            if (timeSinceEntered > playDelay)
            {
                PlaySound(animator.gameObject.transform.position);
                hasDelayedSoundPlayed = true;
            }
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (playOnExit)
        {
            PlaySound(animator.gameObject.transform.position);
        }
    }
}
