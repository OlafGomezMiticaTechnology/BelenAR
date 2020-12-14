using easyar;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerARBehaviour : MonoBehaviour
{
    TargetController imageTargetController;

    [SerializeField]
    GameObject easyGO;
    [SerializeField]
    GameObject canvasGO;


    private void Awake()
    {
        imageTargetController = GetComponent<ImageTargetController>();
    }

    private void OnEnable()
    {
        imageTargetController.TargetFound += OnMarkerFounded;
    }

    private void OnMarkerFounded()
    {
        easyGO.SetActive(false);
        canvasGO.SetActive(true);
    }

    private void OnDisable()
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
}
