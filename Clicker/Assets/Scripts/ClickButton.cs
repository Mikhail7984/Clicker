using TMPro;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public TMP_Text goldText;
    public int clicks;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");

            clicks += 1;

            goldText.text = $"Gold: {clicks}";
        }
    }
}
