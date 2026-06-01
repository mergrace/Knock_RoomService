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
    public AudioClip knock;



    public void PlaySFX(AudioClip clip)
    {
        if (SFXSource.isPlaying)
            SFXSource.Stop();

        SFXSource.PlayOneShot(clip);
    }

    public void PlayKnock()
    {
        SFXSource.PlayOneShot(knock);
    }





}


