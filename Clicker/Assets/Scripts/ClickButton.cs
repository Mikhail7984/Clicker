using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ClickButton : MonoBehaviour, IPointerDownHandler
{
    public TMP_Text clickText;
    public int clicks;
    public int amount = 1;

    public void OnPointerDown(PointerEventData eventData)
    {
        clicks += 1;
        clickText.text = $"Clicks: {clicks}";
    }
}
