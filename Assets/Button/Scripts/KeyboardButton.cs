/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyboardButton : MonoBehaviour
{
    Keyboard keyboard;
    TextMeshProUGUI buttonText;
    void Start()
    {
        keyboard = GetComponentInParent<Keyboard>();
        buttonText =GetComponentInChildren<TextMeshProUGUI>();
        if (buttonText.text.Length == 1)
        {
            NameTobuttonText();
            GetComponentInChildren<ButtonKB>().onRelease.AddListener(delegate { keyboard.insertChar(buttonText.text); });
        }
    }
    public void NameTobuttonText()
    {
        buttonText.text = gameObject.name;
    }
 
}
*/