using UnityEngine;

/// <summary>
/// play audio source when collider trigger hit
/// </summary>
public class SoundTrigger : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // something has hit our collider trigger
        // so start playing the sound
        audioSource.Play();
	}
}