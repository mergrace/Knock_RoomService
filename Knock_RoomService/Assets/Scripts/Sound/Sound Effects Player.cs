using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sound();
    }
    
    public void Sound()
    {
        src.clip = sfx1;
        src.Play();
    }


  

    // Update is called once per frame
    void Update()
    {
        
    }
}
