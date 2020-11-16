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


    private AudioSource source;

    public void SetSource(AudioSource _source, int j)
    {
        source = _source;
        this.source.clip = this.clip[j];
    }

    public void Play()
    {
        source.volume = volume * (1 + Random.Range(-randomVolume / 2f, randomVolume / 2f));
        source.pitch = pitch * (1 + Random.Range(-randomPitch / 2f, randomPitch / 2f));
        source.Play();
    }
}

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField]
    Sound[] sounds;

    void Awake()
    {
        if (instance != null)
            instance = this;
    }

    void Start()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            for (var j = 0; j < this.sounds[i].clip.Length; j++)
            {
                GameObject _go = new GameObject("Sound_" + i + "_" + this.sounds[i].clip[j]);
                _go.transform.SetParent(this.transform);
                this.sounds[i].SetSource(_go.AddComponent<AudioSource>(), j);
            }
        }
    }


    public void PlaySound(int Sound)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (i == Sound)
            {
                RandomAudioClip(i);
                break;
            }
        }

        // no sound with _name
        Debug.LogWarning("AudioManager: Sound not found in list (I canne´ focki´n find eit!): " + Sound);
    }

    void RandomAudioClip(int sound)
    {
        var clipToPlay = Random.Range(0, this.sounds[sound].clip.Length);
        var soundName = this.sounds[sound].clip[clipToPlay].name;

        foreach (var inChild in GetComponentsInChildren<Transform>())
        {
            if (inChild.gameObject == this.gameObject) continue;
            var audioSource = inChild.GetComponent<AudioSource>();
            
            if (audioSource.clip.name != soundName) continue;
            audioSource.Play();
            break;
        }
    }
}