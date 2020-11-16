
using UnityEngine;
[System.Serializable]

public class Sound
{
    public string name;
    public AudioClip [] clip;

    [Range(0f, 1f)]
    public float volume = 0.7f;

    [Range(0.5f, 1.5f)]
    public float pitch = 1f;

    public float randomVolume = 0.1f;
    public float randomPitch = 0.1f;



    private AudioSource source;

    public void SetSource (AudioSource _source)
    {
        source = _source;
        source.clip = clip[0];
    }

    public void Play ()
    {
        source.volume = volume * (1 + Random.Range(-randomVolume / 2f, randomVolume / 2f));
        source.pitch = pitch *(1 + Random.Range(-randomPitch / 2f, randomPitch / 2f));
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

    void Start ()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            for (int j = 0; j < sounds[i].clip.Length; j++)
            {
                GameObject _go = new GameObject("Sound_" + i + "_" + sounds[i].clip[j]);
                _go.transform.SetParent(this.transform);
                sounds[i].SetSource(_go.AddComponent<AudioSource>());
            }

        
        }
                
    }


    public void PlaySound (int Sound)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (i == Sound)
            {
                RandomAudioClip (i);
                return;
            }
        }
        // no sound with _name
        Debug.LogWarning("AudioManager: Sound not found in list (I canne´ focki´n find eit!): " + Sound);
    }

    private void RandomAudioClip(int i)
    {
        var random = Random.Range(0, sounds.Length-1 );
        AudioSource audio = GetComponentInParent<AudioSource>();
        //audio.clip = transform.GetChild(random).GetComponent<AudioSource>();
        audio.clip = sounds[i].clip[random];
        audio.Play();
        Debug.Log($"Playing sound: {sounds[random].name}");
    }
}
