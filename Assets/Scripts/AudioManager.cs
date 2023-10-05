using System.Collections;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
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

        // Start a coroutine to play the second audio clip after the first one finishes
        StartCoroutine(PlaySecondAudioAfterFirst());
    }

    private IEnumerator PlaySecondAudioAfterFirst()
    {
        // Wait for the duration of the first audio clip
        yield return new WaitForSeconds(audioSource.clip.length);

        // Play the second audio clip
        audioSource.clip = walk;
        audioSource.Play();
    }
}
