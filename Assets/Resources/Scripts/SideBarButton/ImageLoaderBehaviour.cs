using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageLoaderBehaviour : MonoBehaviour
{
    public List<Sprite> imageList = new List<Sprite>();

    public List<Sprite> iconList = new List<Sprite>();

    int selfID;

    private void OnEnable()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetID(int id)
    {
        selfID = id;
        LoadImages(selfID);
    }

    void LoadImages(int dictionarykey)
    {
        if (imageList.Count > 0)
            imageList.Clear();

        var imgList = new List<Sprite>(Resources.LoadAll<Sprite>("PlacesID/" + dictionarykey.ToString()));
        imageList = imgList;
    }

   
}
