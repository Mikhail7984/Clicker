using System.Collections;
using UnityEngine;

public class ScreamerScript : MonoBehaviour
{
    public AudioClip screamerSound;

    private SpriteRenderer _spriteRenderer;
    private AudioSource _audioSource;
    private bool _canPlay = true;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _audioSource = GetComponent<AudioSource>();

        if (_audioSource != null)
            Debug.Log("audio is here");
    }

    private void Update()
    {
        if (ClickButton.clicks >= 1000 && _canPlay)
        {
            StartCoroutine(Screamer());
        }
    }

    private IEnumerator Screamer()
    {
        _spriteRenderer.enabled = true;
        _audioSource.PlayOneShot(screamerSound, .170f);

        yield return new WaitForSeconds(3f);

        _canPlay = false;

        _spriteRenderer.enabled = false;
        _audioSource.Stop();
    }
}
