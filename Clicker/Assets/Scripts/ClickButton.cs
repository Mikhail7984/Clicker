using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ClickButton : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("clicked" + gameObject.name);
    }
}
