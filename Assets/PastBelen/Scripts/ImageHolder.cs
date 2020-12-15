using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageHolder : MonoBehaviour
{
    public Image DistanceImageChecker;
    public Button ReadyButton;
    public List<Button> InterestPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        
        ReadyButton.onClick.AddListener(TurnOffOnImage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TurnOffOnImage()
    {
        DistanceImageChecker.enabled = !DistanceImageChecker.enabled;
        foreach (var item in InterestPoints)
        {
            item.gameObject.SetActive(!item.isActiveAndEnabled);
        }

        if (DistanceImageChecker.enabled)
            ReadyButton.GetComponentInChildren<Text>().text = "Ready";
        else
            ReadyButton.GetComponentInChildren<Text>().text = "Resync";
    }
    //void ResyncMethod()
    //{
    //    DistanceImageChecker.enabled = !DistanceImageChecker.enabled;
    //    foreach (var item in InterestPoints)
    //    {
    //        item.gameObject.SetActive(false);
    //    }
    //}
}
