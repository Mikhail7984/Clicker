using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections;

public class Multiplier : MonoBehaviour, IPointerDownHandler
{
    public TMP_Text multiplierText;

    private ClickButton _text;

    private int _price = 100;

    private AudioSource _audioSource;

    private void Awake()
    {
        _text = FindAnyObjectByType<ClickButton>();
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (ClickButton.clicks >= _price)
        {
            ClickButton.clicks = 0;
            _price *= 2;
            ClickButton.amount *= 2;
            _audioSource.Play();
            _text.clickText.text = "Clicks: 0";
            multiplierText.text = "Multiplier is bought.";
            StartCoroutine(Wait());
        }
        else
        {
            multiplierText.text = $"Not enough clicks ({ClickButton.clicks} / {_price})";
            _audioSource.Play();
            StartCoroutine(Wait());
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

        multiplierText.text = "Buy multiplier";
    }
}
