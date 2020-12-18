using easyar;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class MarkerARBehaviour : MonoBehaviour
{
    TargetController imageTargetController;

    [SerializeField]
    GameObject easyGO;
    [SerializeField]
    GameObject canvasGO;


    public static event Action LoadLanguage;
    public static event Action BeginAugmentation;

    private void Awake()
    {
        imageTargetController = GetComponent<ImageTargetController>();
    }

    private void OnEnable()
    {
        
        imageTargetController.TargetFound += OnMarkerFounded;
    }

    private void OnDisable()
    {
        imageTargetController.TargetFound -= OnMarkerFounded;
    }

    private void OnMarkerFounded()
    {
        LoadLanguage?.Invoke();
        easyGO.SetActive(false);
        canvasGO.SetActive(true);
        BeginAugmentation?.Invoke();
    }

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
