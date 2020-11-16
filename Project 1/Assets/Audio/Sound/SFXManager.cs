using UnityEngine;

public class SFXManager : MonoBehaviour {
    public AudioClip[] foodSounds;
    public AudioClip[] stoneSounds;
    public AudioClip[] lumberSounds;
    public AudioClip[] mouseClickSound;

    public void PlayLumberSounds() {
        RandomAudioClip(lumberSounds);
    }
    
    public void PlayFoodSounds() {
        RandomAudioClip(foodSounds);
    }
    
    public void PlayStoneSounds() {
        RandomAudioClip(stoneSounds);
    }

    public void PlayMouseClickSound() {
        RandomAudioClip(mouseClickSound);
    }
    
    private void RandomAudioClip(AudioClip[] array) {
        var random = Random.Range(0, array.Length);
        AudioSource audio = GetComponentInParent<AudioSource>();
        audio.clip = array[random];
        audio.Play();
        Debug.Log($"Playing sound: {array[random].name}");
    }
}
