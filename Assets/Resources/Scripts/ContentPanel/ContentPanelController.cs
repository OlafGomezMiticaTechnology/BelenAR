using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentPanelController : MonoBehaviour
{
    ContentPanelBehaviour panelBehaviour;

    int currentImageIndex;

    private void Awake()
    {
        panelBehaviour = GetComponent<ContentPanelBehaviour>();
    }

    public void SettingGallery(object sender, EventArgs e)
    {
        if(panelBehaviour.GetRightButton() != null)
        {
            panelBehaviour.GetRightButton().onClick.RemoveAllListeners();
            panelBehaviour.GetLeftButton().onClick.RemoveAllListeners();
        }

        var _newContainer = (List<Sprite>)sender;

        panelBehaviour.ReplaceImages(_newContainer);

        currentImageIndex = 0;

        panelBehaviour.GetPanelGallery().sprite = panelBehaviour.GetContainedImages()[currentImageIndex];

        if(panelBehaviour.GetRightButton() != null)
        {
            panelBehaviour.GetRightButton().onClick.AddListener(() => { ShowNextImage(1);});
            panelBehaviour.GetLeftButton().onClick.AddListener(() => { ShowNextImage(-1); });
        }
          
    }

   public void SetPanelContent(List<string> translatedTexts)
   {
        for (int i = 0; i < panelBehaviour.GetPanelTexts().Count; i++)
        {
            panelBehaviour.GetPanelTexts()[i].text = translatedTexts[i];
        }
   }

    void ShowNextImage(int index)
    {
        currentImageIndex += index;

        if (currentImageIndex <= panelBehaviour.GetContainedImages().Count - 1)
        {
            if (currentImageIndex < 0)
            {
                currentImageIndex = panelBehaviour.GetContainedImages().Count - 1;
            }
        }

        else
        {
            currentImageIndex = 0;
        }

        panelBehaviour.GetPanelGallery().sprite = panelBehaviour.GetContainedImages()[currentImageIndex];
    }
}
