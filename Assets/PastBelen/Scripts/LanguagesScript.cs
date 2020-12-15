using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguagesScript : MonoBehaviour
{
    
    public List<Text> AngelHolders;
    public List<Text> ReyesHolders;
    public List<Text> StationHolders;
    public List<Text> PicoHolders;

    [Space]
    // Solo tiene un container
    public Text FamHolder;
    public Text TunelHolder;

    public LanguageChoosed LanguageChoosedSC;
    public TextData SelectedSC;

    [Space]

    public List<Text> AngelHoldersFullScreen;
    public List<Text> ReyesHoldersFullScreen;
    public Text StationHoldersFullScreen;
    public Text PicoHoldersFullScreen;
    public List<Text> FamHoldersFullScreen;
    public Text TunelHoldersFullScreen;



    public Text AngelTagText;
    public Text TunelTagText;
    public Text FamTagText;
    public Text ReyesTagText;
    public Text PicoTagText;
    public Text EstancionTagText;

    public Text SecondAngelTagText;
    public Text SecondTunelTagText;
    public Text SecondFamTagText;
    public Text SecondReyesTagText;
    public Text SecondPicoTagText;
    public Text SecondEstancionTagText;




    [Space]

    public List<Text> SecondAngelHoldersFullScreen;
    public List<Text> SecondReyesHoldersFullScreen;
    public Text SecondStationHoldersFullScreen;
    public Text SecondPicoHoldersFullScreen;
    public List<Text> SecondFamHoldersFullScreen;
    public Text SecondTunelHoldersFullScreen;

    [Space]
    public Text GalleryTagText;
    public Text SecondGalleryTagText;

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


        for (int i = 0; i < AngelHolders.Count; i++)
        {
            AngelHolders[i].text = SelectedSC.AngelTexts[i];
            AngelHoldersFullScreen[i].text = SelectedSC.AngelTexts[i];
            SecondAngelHoldersFullScreen[i].text = SelectedSC.AngelTexts[i];


            ReyesHolders[i].text = SelectedSC.ReyesTexts[i];
            ReyesHoldersFullScreen[i].text = SelectedSC.ReyesTextsFullScreen[i];
            SecondReyesHoldersFullScreen[i].text = SelectedSC.ReyesTextsFullScreen[i];
        }

        for (int i = 0; i < PicoHolders.Count; i++)
        {
            PicoHolders[i].text = SelectedSC.PicoTexts[i];
            StationHolders[i].text = SelectedSC.StationTexts[i];
            FamHoldersFullScreen[i].text = SelectedSC.FamTextsFullScreen[i];


            SecondFamHoldersFullScreen[i].text = SelectedSC.FamTextsFullScreen[i];


        }

        FamHolder.text = SelectedSC.famText;
        TunelHolder.text = SelectedSC.tunelText;

        // Fullscreen
        StationHoldersFullScreen.text = SelectedSC.StationTextFullScreen;
        PicoHoldersFullScreen.text = SelectedSC.PicoTextFullScreen;
        TunelHoldersFullScreen.text = SelectedSC.tunelText;

        SecondStationHoldersFullScreen.text = SelectedSC.StationTextFullScreen;
        SecondPicoHoldersFullScreen.text = SelectedSC.PicoTextFullScreen;
        SecondTunelHoldersFullScreen.text = SelectedSC.tunelText;

        //SelectedSC.TagData();

        //AngelTagText.text = SelectedSC.GetAngelTag();
        //TunelTagText.text = SelectedSC.GetTunelTag();
        //FamTagText.text = SelectedSC.GetFamTag();
        //ReyesTagText.text = SelectedSC.GetReyesTag();
        //PicoTagText.text = SelectedSC.GetPicoTag();
        //EstancionTagText.text = SelectedSC.GetStationTag();

        //SecondAngelTagText.text = SelectedSC.GetAngelTag();
        //SecondTunelTagText.text = SelectedSC.GetTunelTag();
        //SecondFamTagText.text = SelectedSC.GetFamTag();
        //SecondReyesTagText.text = SelectedSC.GetReyesTag();
        //SecondPicoTagText.text = SelectedSC.GetPicoTag();
        //SecondEstancionTagText.text = SelectedSC.GetStationTag();

        //GalleryTagText.text = SelectedSC.GetGalleryTag();
        //SecondGalleryTagText.text = SelectedSC.GetGalleryTag();
    }
}
