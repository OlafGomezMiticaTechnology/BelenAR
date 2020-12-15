using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageVisualizer : MonoBehaviour
{
    public List<Sprite> Sprites;
    int currentImageshowed;
    public Image ImageViewer;

    public void NextImage()
    {
        if (currentImageshowed < Sprites.Count - 1)
            currentImageshowed++;

        else if (currentImageshowed >= Sprites.Count - 1)
            currentImageshowed = 0;


        ImageViewer.sprite = Sprites[currentImageshowed];
    }

    public void PreviousImage()
    {
        if (currentImageshowed <= 0)
            currentImageshowed = Sprites.Count - 1;

        else if (currentImageshowed > 0)
            currentImageshowed--;

        ImageViewer.sprite = Sprites[currentImageshowed];
    }

    // Start is called before the first frame update
    void Start()
    {
        ImageViewer.sprite = Sprites[currentImageshowed];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
