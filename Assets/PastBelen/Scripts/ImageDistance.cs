using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDistance : MonoBehaviour
{
    public GameObject ImageTargetOne;
    public GameObject ImageTargetTwo;

    public GameObject TextContainerOne;
    public GameObject TextContainerTwo;

   // public DefaultTrackableEventHandler m_Tracker;

    bool IsTheUserCloseToTheMarker() => Vector3.Distance(transform.position, ImageTargetOne.transform.position) < .5f;

    bool isShowingTargetOne;

    private void OnEnable()
    {
        //m_Tracker.OnTargetFound.AddListener(ShowContent);
        //m_Tracker.OnTargetLost.AddListener(HideAll);
    }

    private void OnDisable()
    {
        //m_Tracker.OnTargetFound.RemoveListener(ShowContent);
        //m_Tracker.OnTargetLost.RemoveListener(HideAll);
    }

    private void Awake()
    {
        HideAll();
    }

    void ShowContent()
    {
        StartCoroutine(AugmentedContent());
    }

    IEnumerator AugmentedContent()
    {
        for (; ;)
        {
            if (IsTheUserCloseToTheMarker() && isShowingTargetOne || !IsTheUserCloseToTheMarker() && !isShowingTargetOne)
            {
                yield return null;
            }

            if (IsTheUserCloseToTheMarker() && !isShowingTargetOne)
            {
                ShowDesiredTargetContent(ImageTargetOne, TextContainerOne);
                HideDesiredTargetContent(ImageTargetTwo, TextContainerTwo);
                isShowingTargetOne = true;
            }

            else if(!IsTheUserCloseToTheMarker() && isShowingTargetOne)
            {
                ShowDesiredTargetContent(ImageTargetTwo, TextContainerTwo);
                HideDesiredTargetContent(ImageTargetOne, TextContainerOne);
                isShowingTargetOne = false;
            }
        }

    }

    void ShowDesiredTargetContent(GameObject imageTarget, GameObject textContainer)
    {
        imageTarget.SetActive(true);
        textContainer.SetActive(true);
    }

    void HideDesiredTargetContent(GameObject imageTarget, GameObject textContainer)
    {
        imageTarget.SetActive(false);
        textContainer.SetActive(false);
    }

    void HideAll()
    {
        HideDesiredTargetContent(ImageTargetOne, TextContainerOne);
        HideDesiredTargetContent(ImageTargetTwo, TextContainerTwo);
    }
}
