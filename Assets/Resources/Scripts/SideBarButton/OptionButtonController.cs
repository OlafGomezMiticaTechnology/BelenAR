using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButtonController : MonoBehaviour
{
    OptionButtonBehaviour optionButtonBehaviour;
    ImageLoaderBehaviour imageLoaderBehaviour;
    ButtonColorBehaviour buttonColorBehaviour;

    public event EventHandler ButtonPressed;

    private void OnDisable()
    {
        optionButtonBehaviour.selfButton.onClick.RemoveListener(OnClicking);
    }

    private void Awake()
    {
        optionButtonBehaviour = GetComponent<OptionButtonBehaviour>();
        imageLoaderBehaviour = GetComponent<ImageLoaderBehaviour>();
        buttonColorBehaviour = GetComponent<ButtonColorBehaviour>();
    }

    public void SettingContent(string title, int btnID)
    {
        optionButtonBehaviour.SetSelfButtonTitle(title);
        imageLoaderBehaviour.SetID(btnID);
        optionButtonBehaviour.LoadIcons(btnID);
        optionButtonBehaviour.selfButton.onClick.AddListener(OnClicking);


    }

    public void OnClicking()
    {
        SendingButtonInteraction(this, EventArgs.Empty);
       
    }

    private void SendingButtonInteraction(object sender, EventArgs e)
    {
        ButtonPressed?.Invoke(sender, e);
    }

    public Button GetSelfButton()
    {
       return optionButtonBehaviour.selfButton;
    }

    public List<Sprite> GetImagesAsSprites()
    {
        return imageLoaderBehaviour.imageList;
    }

    public string GetTitle()
    {
        return optionButtonBehaviour.GetSelfTitle();
    }

    public void SetButtonColorPressed()
    {
        buttonColorBehaviour.SetPressedColor();
    }

    public void SetButtonColorDefault()
    {
        buttonColorBehaviour.SetDefaultColor();
    }

    public void ActiveContent()
    {
        optionButtonBehaviour.ActiveContent();
    }

    public void DeactiveContent()
    {
        optionButtonBehaviour.DeactiveContent();
    }

}
