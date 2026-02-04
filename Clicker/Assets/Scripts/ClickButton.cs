using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ClickButton : MonoBehaviour, IPointerDownHandler
{
    public TMP_Text clickText;
    [SerializeField] public static int clicks;
    public static int amount = 1;

    public void OnPointerDown(PointerEventData eventData)
    {
        clicks += amount;
        clickText.text = $"Clicks: {clicks}";
    }
}
