using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ClickButton : MonoBehaviour, IPointerDownHandler
{
    public TMP_Text clickText;
    public static int clicks;
    public static int amount = 20;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        clicks += amount;
        clickText.text = $"Clicks: {clicks}";

        _audioSource.Play();
    }
}
