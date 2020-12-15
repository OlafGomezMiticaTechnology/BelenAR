using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChangerController : MonoBehaviour
{
    [SerializeField]
    Image GalleryImage;

    List<Sprite> imageContainter = new List<Sprite>();

    [SerializeField]
    Button buttonRight;
    [SerializeField]
    Button buttonLeft;

    int currentImageIndex;

    private void OnEnable()
    {
        OptionButtonManager.ChangeImageContainer += OptionButtonManager_ChangeImageContainer;
        buttonRight.onClick.AddListener(() => { ShowNextImage(1); });
        buttonLeft.onClick.AddListener(() => { ShowNextImage(-1); });
    }

    private void OnDisable()
    {
        OptionButtonManager.ChangeImageContainer -= OptionButtonManager_ChangeImageContainer;

        buttonRight.onClick.RemoveAllListeners();
        buttonLeft.onClick.RemoveAllListeners();
    }

    private void OptionButtonManager_ChangeImageContainer(object sender, EventArgs e)
    {
        var _newContainer = (List<Sprite>)sender;

        imageContainter = _newContainer;

        currentImageIndex = 0;

        GalleryImage.sprite = imageContainter[currentImageIndex];
    }


    void ShowNextImage(int index)
    {
        currentImageIndex += index;

        if (currentImageIndex <= imageContainter.Count -1)
        {
            if (currentImageIndex < 0 )
            {
                currentImageIndex = imageContainter.Count - 1;
            }
        }

        else
        {
            currentImageIndex = 0;
        }

        GalleryImage.sprite = imageContainter[currentImageIndex];
    }
   
}
