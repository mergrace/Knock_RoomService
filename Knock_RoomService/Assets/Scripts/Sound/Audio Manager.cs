using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip ghostdeath;
    public AudioClip vampiredeath;
    public AudioClip ghouldeath;
    public AudioClip keycollect;
    public AudioClip playerdeath;



    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}


