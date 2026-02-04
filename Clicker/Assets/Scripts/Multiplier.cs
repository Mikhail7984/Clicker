using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections;

public class Multiplier : MonoBehaviour, IPointerDownHandler
{
    public TMP_Text multiplierText;

    private ClickButton text;

    private void Awake()
    {
        text = FindAnyObjectByType<ClickButton>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (ClickButton.clicks >= 100)
        {
            ClickButton.clicks = 0;
            ClickButton.amount = 2;
            text.clickText.text = "Clicks: 0";
            multiplierText.text = "Multiplier is bought.";
            StartCoroutine(Wait());
        }
        else
        {
            multiplierText.text = $"Not enough clicks ({ClickButton.clicks} / 100)";
            StartCoroutine(Wait());
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

        multiplierText.text = "Buy multiplier";
    }
}
