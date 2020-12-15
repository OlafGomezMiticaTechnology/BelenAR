using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XmasGifContent : MonoBehaviour
{
    public GameObject ImageTargetOne;
    public GameObject TextContainerOne;

    //public DefaultTrackableEventHandler m_Tracker;

    private void OnEnable()
    {
        //m_Tracker.OnTargetFound.AddListener(ShowDesiredTargetContent);
        //m_Tracker.OnTargetLost.AddListener(HideDesiredTargetContent);
    }

    private void Awake()
    {
        ShowDesiredTargetContent();
    }

    private void OnDisable()
    {
        //m_Tracker.OnTargetFound.RemoveListener(ShowDesiredTargetContent);
        //m_Tracker.OnTargetLost.RemoveListener(HideDesiredTargetContent);
    }

    void ShowDesiredTargetContent()
    {
        ImageTargetOne.SetActive(true);
        TextContainerOne.SetActive(true);
    }

    void HideDesiredTargetContent()
    {
        ImageTargetOne.SetActive(false);
        TextContainerOne.SetActive(false);
    }
}
