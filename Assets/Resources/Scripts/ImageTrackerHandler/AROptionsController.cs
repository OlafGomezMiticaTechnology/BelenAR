using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AROptionsController : MonoBehaviour
{

    public static event Action AdditionFinished;
    

    [SerializeField]
    OptionButtonController OptionButton;
    [SerializeField]
    VerticalLayoutGroup BarContainer;
    [SerializeField]
    OptionButtonManager optionButtonManager;

    TextData loadedData;

    private void OnEnable()
    {
        MarkerARBehaviour.BeginAugmentation += CreateButtonsInSideBar;
    }

    private void OnDisable()
    {
        MarkerARBehaviour.BeginAugmentation -= CreateButtonsInSideBar;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateButtonsInSideBar()
    {
        if(loadedData == null)
        {
            loadedData = GetComponent<LanguageController>().SelectedSC;

            for (int i = 0; i < loadedData.GetAllOptionsDictionary().Values.Count; i++)
            {
                OptionButtonController _go = Instantiate(OptionButton, BarContainer.transform);

                string _dictionaryValue;

                loadedData.GetAllOptionsDictionary().TryGetValue(i, out _dictionaryValue);

                if (!string.IsNullOrEmpty(_dictionaryValue))
                {
                    _go.SettingContent(_dictionaryValue, i);
                    optionButtonManager.PopulationList(_go);
                }

                else
                {
                    print("nada");
                }

            }

            AdditionFinished?.Invoke();
        }
    }

    
}
