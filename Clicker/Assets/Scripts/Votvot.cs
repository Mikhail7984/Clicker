using UnityEngine;

public class Votvot : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (ClickButton.clicks > 600)
        {
            _audioSource.Play();
        }
        if (ClickButton.clicks >= 990)
        {
            _audioSource.Stop();
        }
    }
}
