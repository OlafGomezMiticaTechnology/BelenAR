using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelManagement : MonoBehaviour
{
    //public DefaultTrackableEventHandler Tracker;
    public List<Text> Labels;

    private void OnEnable()
    {
      //  Tracker.OnTargetFound.AddListener(ShowLabelContent);
      //  Tracker.OnTargetLost.AddListener(HideLabelContent);
    }

    private void OnDisable()
    {
        //Tracker.OnTargetFound.RemoveListener(ShowLabelContent);
        //Tracker.OnTargetLost.RemoveListener(HideLabelContent);
    }

    private void Awake()
    {
        HideLabelContent();
    }


    void ShowLabelContent()
    {
        foreach (var item in Labels)
        {
            item.gameObject.SetActive(true);
        }
    }

    void HideLabelContent()
    {
        foreach (var item in Labels)
        {
            item.gameObject.SetActive(false);
        }
    }
}
