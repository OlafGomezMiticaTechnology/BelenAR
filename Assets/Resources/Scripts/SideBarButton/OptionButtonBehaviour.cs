using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButtonBehaviour : MonoBehaviour
{
    string selfTitle;

    public Button selfButton;

    [SerializeField]
    Text selfText;

    [SerializeField]
    Image selfIcon;

    [SerializeField]
    Image selfSelectedImage;

    Color originalIconColor;

    [SerializeField]
    Color selectedColor;
    private void Awake()
    {
        selfButton = GetComponent<Button>();
        originalIconColor = selfIcon.color;
    }
    public void SetSelfButtonTitle(string title)
    {
        selfTitle = title;
        selfText.text = selfTitle;
    }

    public string GetSelfTitle()
    {
        return selfTitle;
    }

    public void ActiveContent()
    {
        selfIcon.color = selectedColor;
        selfSelectedImage.gameObject.SetActive(true);
    }

    public void DeactiveContent()
    {
        selfIcon.color = originalIconColor;
        selfSelectedImage.gameObject.SetActive(false);
    }
    public void LoadIcons(int dictionarykey)
    {
        var imgList = Resources.LoadAll<Sprite>("Icons/" + dictionarykey.ToString());
        selfIcon.sprite = imgList[0];
    }
}
