using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageController : MonoBehaviour
{
    [SerializeField]
    LanguageChoosed languageChoosedSC;
    public TextData SelectedSC;

    public static event EventHandler SendTranslation;
    private void OnEnable()
    {
        MarkerARBehaviour.LoadLanguage += SelectingLanguage;
    }

    private void OnDisable()
    {
        MarkerARBehaviour.LoadLanguage -= SelectingLanguage;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectingLanguage()
    {
        switch (languageChoosedSC.LanguageChoosedByUser)
        {
            case 0:
                SelectedSC = Resources.Load<TextData>("LanguagesScriptables/Spanish");
                break;
            case 1:
                SelectedSC = Resources.Load<TextData>("LanguagesScriptables/English");

                break;
            case 2:
                SelectedSC = Resources.Load<TextData>("LanguagesScriptables/German");

                break;

            default:
                break;
        }

       if(SelectedSC.GetAllOptionsDictionary().Keys.Count == 0)
       {
            SelectedSC.SetAllOptionListElements();
       }

        OnLoadedTranslation(SelectedSC, EventArgs.Empty);
    }

    private void OnLoadedTranslation(object send, EventArgs e)
    {
        SendTranslation?.Invoke(send, e);
    }
}
