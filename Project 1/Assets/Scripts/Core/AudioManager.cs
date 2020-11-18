using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sound[] sounds;

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