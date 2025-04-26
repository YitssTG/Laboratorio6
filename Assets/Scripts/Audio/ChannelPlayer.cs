using UnityEngine;
using UnityEngine.Audio;
public class ChannelPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSettings audioSettings;

    [Header("Music Start")]
    [SerializeField] private bool playMusicOnStart = false;
    [SerializeField] private AudioData audioData;
    public AudioMixerGroup PlayerChannel => audioSource.outputAudioMixerGroup;
    private void Awake()
    {
        audioSource.outputAudioMixerGroup = audioSettings.AudioMixerGroup;
        audioSource.loop = true;
    }
    private void Start()
    {
        if (playMusicOnStart && audioData !=null)
        {
            PlayerClip(audioData.AudioClip);
        }
    }
    public void PlayerClip(AudioClip clipToPlay)
    {
        audioSource.Stop();
        audioSource.clip = clipToPlay;
        audioSource.Play();
    }
}
