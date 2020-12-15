using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagsTagsScript : MonoBehaviour
{
    public LanguageChoosed LanguageChoosedSC;
    public TextData SelectedSC;

    public Text Experience;
    public Text Belen;
    public Text Card;

    private void Awake()
    {
        switch (LanguageChoosedSC.LanguageChoosedByUser)
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

        //Experience.text = SelectedSC.GetExperienceTag();
        //Belen.text = SelectedSC.GetBelenExperienceTag();
        //Card.text = SelectedSC.GetCardExperienceTag();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
