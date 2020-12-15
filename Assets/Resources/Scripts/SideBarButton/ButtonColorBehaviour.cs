using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorBehaviour : MonoBehaviour
{
    Button selfButton;
    Color defaultColor;

   

    private void Awake()
    {
        selfButton = GetComponent<Button>();
        defaultColor = selfButton.colors.normalColor;
    }

    private Color PressedColor()
    {
        return selfButton.colors.pressedColor;
    }

    private Color GetDefaultColor()
    {
        return defaultColor;
    }

    public void SetPressedColor()
    {
        var _colors = selfButton.colors;
        _colors.normalColor = selfButton.colors.pressedColor;
        selfButton.colors = _colors;
    }

    public void SetDefaultColor()
    {
        var _colors = selfButton.colors;
        _colors.normalColor = defaultColor;
        selfButton.colors = _colors;
    }
}
