using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ClickButton : MonoBehaviour, IPointerDownHandler
{
    public TMP_Text clickText;
    public static int clicks;
    public static int amount = 1;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        clicks += amount;
        clickText.text = $"Clicks: {clicks}";

        audioSource.Play();
    }
}
