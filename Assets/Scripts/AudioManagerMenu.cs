using System.Collections;
using UnityEngine;

public class AudioManagerMenuScript : MonoBehaviour
{
    public AudioClip Start2;
    public AudioClip walk;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Play the first audio clip when the scene starts
        audioSource.clip = Start2;
        audioSource.Play();
    }
}
