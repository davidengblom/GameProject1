using UnityEngine;

public class SFXTestScript : MonoBehaviour {
    public AudioClip[] FoodSounds;
    public AudioClip[] StoneSounds;
    public AudioClip[] LumberSounds;

    public void PlayLumberSounds()
    {
        var random = Random.Range(0, LumberSounds.Length);
        AudioSource audio = GetComponentInParent<AudioSource>();
        audio.clip = LumberSounds[random];
        audio.Play();
        Debug.Log("Playing Sound nr: " + LumberSounds[random].name);
    }
    
    public void PlayFoodSounds()
    {
        var random = Random.Range(0, FoodSounds.Length);
        AudioSource audio = GetComponentInParent<AudioSource>();
        audio.clip = FoodSounds[random];
        audio.Play();
        Debug.Log("Playing Sound nr: " + FoodSounds[random].name);
    }
    
    public void PlayStoneSounds()
    {
        var random = Random.Range(0, StoneSounds.Length);
        AudioSource audio = GetComponentInParent<AudioSource>();
        audio.clip = StoneSounds[random];
        audio.Play();
        Debug.Log("Playing Sound nr: " + StoneSounds[random].name);
    }
}
