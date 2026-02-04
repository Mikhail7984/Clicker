using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections;

public class Multiplier : MonoBehaviour, IPointerDownHandler
{
    public TMP_Text multiplierText;

    private ClickButton text;

    private int price = 100;

    private AudioSource audioSource;

    private void Awake()
    {
        text = FindAnyObjectByType<ClickButton>();
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (ClickButton.clicks >= price)
        {
            ClickButton.clicks = 0;
            price *= 2;
            ClickButton.amount *= 2;
            audioSource.Play();
            text.clickText.text = "Clicks: 0";
            multiplierText.text = "Multiplier is bought.";
            StartCoroutine(Wait());
        }
        else
        {
            multiplierText.text = $"Not enough clicks ({ClickButton.clicks} / {price})";
            audioSource.Play();
            StartCoroutine(Wait());
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

        multiplierText.text = "Buy multiplier";
    }
}
