using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Language", menuName = "Language")]
public class TextData : ScriptableObject
{
    Dictionary<int, string> optionsDictionary = new Dictionary<int, string>();
//    List<string> allOptions = new List<string>();


    public List<string> AngelTexts = new List<string>();
    public List<string> ReyesTexts = new List<string>();
    public List<string> StationTexts = new List<string>();
    public List<string> PicoTexts = new List<string>();
    public string famText;
    public string tunelText;



    public List<string> ReyesTextsFullScreen = new List<string>();
    public string StationTextFullScreen;
    public string PicoTextFullScreen;
    public List<string> FamTextsFullScreen = new List<string>();

    [SerializeField]
    private string famTag;
    [SerializeField]
    private string reyesTag;
    [SerializeField]
    private string angelTag;
    [SerializeField]
    private string stationTag;
    [SerializeField]
    private string tunelTag;
    [SerializeField]
    private string picoTag;

    [SerializeField]
    private string experienceTag;
    [SerializeField]
    private string belenExperienceTag;
    [SerializeField]
    private string cardExperienceTag;

    [SerializeField]
    private string galleryTag;


    
    public List<string> GetContentText(int panelIndex)
    {
        List<string> _stationList = new List<string>();
        _stationList.Add(StationTextFullScreen);

        List<string> _tunerList = new List<string>();
        _tunerList.Add(tunelText);

        List<string> _picoList = new List<string>();
        _picoList.Add(PicoTextFullScreen);

        List<string> _galleryList = new List<string>();
        _galleryList.Add(galleryTag);

        switch (panelIndex)
        {
            case 0:
                return FamTextsFullScreen;
            case 1:
                return ReyesTextsFullScreen;
            case 2:
                return AngelTexts;
            case 3:
                return _stationList;
            case 4:
                return _tunerList;
            case 5:
                return _picoList;
            default:
                return _galleryList;
        }
    }
    

    public Dictionary<int, string> GetAllOptionsDictionary()
    {
        return optionsDictionary;
    }

    public void SetTagData(string famTag, string reyesTag, string angelTag, string stationTag, string tunelTag, string picoTag, string gallTag)
    {
        this.famTag = famTag;
        this.reyesTag = reyesTag;
        this.angelTag = angelTag;
        this.stationTag = stationTag;
        this.tunelTag = tunelTag;
        this.picoTag = picoTag;
        this.galleryTag = gallTag;

        
        //allOptions.Add(this.galleryTag);
    }

    public void SetExperienceTagData(string expTag, string blnExpTag, string cardExpTag)
    {
        this.experienceTag = expTag;
        this.belenExperienceTag = blnExpTag;
        this.cardExperienceTag = cardExpTag;
    }


    //public void TagData()
    //{
    //    Debug.Log(this.famTag);
    //    Debug.Log(this.reyesTag);
    //    Debug.Log(this.angelTag);
    //    Debug.Log(this.stationTag);
    //    Debug.Log(this.tunelTag);
    //    Debug.Log(this.picoTag);
    //}

    public void SetAllOptionListElements()
    {
        optionsDictionary.Add(0, this.famTag);
        optionsDictionary.Add(1, this.reyesTag);
        optionsDictionary.Add(2, this.angelTag);
        optionsDictionary.Add(3, this.stationTag);
        optionsDictionary.Add(4, this.tunelTag);
        optionsDictionary.Add(5, this.picoTag);
        optionsDictionary.Add(6, this.galleryTag);
    }

    public void ClearOptionListElements()
    {
        optionsDictionary.Clear();
    }
}
