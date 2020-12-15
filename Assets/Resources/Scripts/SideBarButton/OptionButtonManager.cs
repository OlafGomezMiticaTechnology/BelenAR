using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButtonManager : MonoBehaviour
{
    public static event Action OnCreatedButtons;
    List<OptionButtonController> buttonControllers = new List<OptionButtonController>();

    public static event EventHandler ChangeImageContainer;
    public static event EventHandler ChangeActivePanel;
    private void OnEnable()
    {
        AROptionsController.AdditionFinished += AROptionsController_AdditionFinished;
    }

    private void OnDisable()
    {
        AROptionsController.AdditionFinished -= AROptionsController_AdditionFinished;

        foreach (var item in buttonControllers)
        {
            item.ButtonPressed -= Item_ButtonPressed;
        }
    }

    private void AROptionsController_AdditionFinished()
    {
        foreach (var item in buttonControllers)
        {
            item.ButtonPressed += Item_ButtonPressed;
        }

        buttonControllers[0].GetSelfButton().onClick.Invoke();
        buttonControllers[0].SetButtonColorPressed();
    }

    private void Item_ButtonPressed(object sender, EventArgs e)
    {
        var _castedobj = (OptionButtonController)sender;
        

        for (int i = 0; i < buttonControllers.Count; i++)
        {
            if(buttonControllers[i] != _castedobj)
            {
                buttonControllers[i].SetButtonColorDefault();
                buttonControllers[i].DeactiveContent();
            }

            else
            {
                buttonControllers[i].SetButtonColorPressed();
                buttonControllers[i].ActiveContent();
                
                OnChangingActivePanel(i, EventArgs.Empty);
            }
        }

        OnChangingImagecontainer(_castedobj.GetImagesAsSprites(), EventArgs.Empty);
    }


    public void PopulationList(OptionButtonController btn)
    {
        buttonControllers.Add(btn);
    }

    private void OnChangingImagecontainer(object sender, EventArgs e)
    {
        ChangeImageContainer?.Invoke(sender, e);
    }

    private void OnChangingActivePanel(object sender, EventArgs e)
    {
        ChangeActivePanel?.Invoke(sender, e);
    }
}
