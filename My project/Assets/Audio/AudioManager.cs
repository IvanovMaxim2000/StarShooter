using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    private void OnEnable() => Target.onDestroyed += PlaySound;
    private void OnDisable() => Target.onDestroyed -= PlaySound;
    private void PlaySound() => audioSource.Play();
}
