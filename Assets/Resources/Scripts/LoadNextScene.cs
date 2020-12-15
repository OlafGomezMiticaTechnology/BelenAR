using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField]
    GameObject startInstruccions;
    // Start is called before the first frame update

    //private void Awake()
    //{
    //    if (PlayerPrefs.GetInt("FirstTime") >= 1)
    //    {
    //        return;
    //    }

    //    else if (PlayerPrefs.GetInt("FirstTime") <= 0)
    //    {
    //        PlayerPrefs.SetInt("FirstTime", 1);

    //    }
    //}

    private void Awake()
    {
        if (PlayerPrefs.GetInt("FirstTime") >= 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

        else if (PlayerPrefs.GetInt("FirstTime") <= 0)
        {
            PlayerPrefs.SetInt("FirstTime", 1);
            startInstruccions.SetActive(true);

        }
    }




    //public void NextScene()
    //{
       


    //    if (PlayerPrefs.GetInt("FirstTime") >= 1)
    //    {
    //        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    //    }

    //    else if (PlayerPrefs.GetInt("FirstTime") <= 0)
    //    {
    //        PlayerPrefs.SetInt("FirstTime", 1);
    //        UnityEngine.SceneManagement.SceneManager.LoadScene(1);

    //    }

    //}

    public void NextSceneGeneric(int scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

    public void OpenWebBrowser()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1moP1_I7yRFznL6ez9J48pb-cKDfWkcMt?usp=sharing");
    }
}
