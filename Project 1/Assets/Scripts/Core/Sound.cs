using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip[] clip;

    [Range(0f, 1f)]
    public float volume = 0.7f;

    [Range(0.5f, 1.5f)]
    public float pitch = 1f;

    public float randomVolume = 0.1f;
    public float randomPitch = 0.1f;


    public AudioSource source;

    public void SetSource(AudioSource _source, int j)
    {
        this.source = _source;
        this.source.clip = this.clip[j];
    }

    public void Play()
    {
        this.source.volume = this.volume * (1 + Random.Range(-this.randomVolume / 2f, this.randomVolume / 2f));
        this.source.pitch = this.pitch * (1 + Random.Range(-this.randomPitch / 2f, this.randomPitch / 2f));
        this.source.Play();
    }
}