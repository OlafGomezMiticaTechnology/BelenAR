using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentPanelManager : MonoBehaviour
{
    [SerializeField]
    List<ContentPanelController> contentPanelControllers = new List<ContentPanelController>();
    ContentPanelController selectedPanel;

    
    [SerializeField]
    TextData loadedSC;

    int panelIndex;
    private void OnEnable()
    {
        
        LanguageController.SendTranslation += AROptionsController_SendTranslation;
        OptionButtonManager.ChangeActivePanel += OptionButtonManager_ChangeActivePanel;
        OptionButtonManager.ChangeImageContainer += OptionButtonManager_ChangeImageContainer;
    }

   

    private void OnDisable()
    {
        LanguageController.SendTranslation -= AROptionsController_SendTranslation;
        OptionButtonManager.ChangeActivePanel -= OptionButtonManager_ChangeActivePanel;
        OptionButtonManager.ChangeImageContainer -= OptionButtonManager_ChangeImageContainer;
    }

    private void AROptionsController_SendTranslation(object sender, EventArgs e)
    {

        if (loadedSC == null)
        {
            var _data = (TextData)sender;
            loadedSC = _data;
        }
    }

    private void OptionButtonManager_ChangeActivePanel(object sender, EventArgs e)
    {
        panelIndex = (int) sender;
        for (int i = 0; i < contentPanelControllers.Count; i++)
        {
            contentPanelControllers[i].gameObject.SetActive(false);
        }

        selectedPanel = contentPanelControllers[panelIndex];
        selectedPanel.gameObject.SetActive(true);
    }

    private void OptionButtonManager_ChangeImageContainer(object sender, EventArgs e)
    {
        selectedPanel.SettingGallery(sender, e);
        var _translatedTexts = loadedSC.GetContentText(panelIndex);
        selectedPanel.SetPanelContent(_translatedTexts);
    }

  
}
