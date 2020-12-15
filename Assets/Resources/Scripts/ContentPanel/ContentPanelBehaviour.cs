using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentPanelBehaviour : MonoBehaviour
{
    [SerializeField]
    List<Text> texts = new List<Text>();

    [SerializeField]
    Image GalleryImage;
    List<Sprite> imageContainter = new List<Sprite>();

    [SerializeField]
    Button buttonRight;
    [SerializeField]
    Button buttonLeft;

    public List<Text> GetPanelTexts()
    {
        return texts;
    }

    public List<Sprite> GetContainedImages()
    {
        return imageContainter;
    }

    public Image GetPanelGallery()
    {
        return GalleryImage;
    }

    public void ReplaceImages(List<Sprite> newList)
    {
        imageContainter = newList;
    }

    public void RemovePreviousImages()
    {
        imageContainter.Clear();
    }

    public Button GetRightButton()
    {
        return buttonRight;
    }

    public Button GetLeftButton()
    {
        return buttonLeft;
    }


}
