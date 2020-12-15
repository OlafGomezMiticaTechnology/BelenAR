using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Lean.Touch;

public class AttachTextToObjects : MonoBehaviour
{
    public Camera Cam;
    public Text Label;
    public Vector3 OffsetAnchorPoint;
    public GameObject Panel;
    public Vector3 OffsetPointAnimation;
    public Transform TextPH;
    public Vector3 OffsetPanel;

    public GameObject InnerCanvas;
    public GameObject InnerPanel;


    Vector3 currentMainObjectPosition;
    Vector3 currentPanelPosition;
    bool isCheckedChanged = true;

    public GameObject CircleIcon;
    MeshRenderer meshRend;
    Vector3 originalCirlcePosition = Vector3.zero;
    //LeanSelectable circleSelectable;
    SphereCollider circleSphereCollider;
    Animator anim;
    const string ISWIDGETSELECTED = "IsWidgetSelected";
    const string NOTOFFSET = "NoNeed";
    public Transform ExpandedCirclePlaceHolder;

  

    // Start is called before the first frame update
    void Start()
    {
        //circleSelectable = CircleIcon.GetComponent<LeanSelectable>();
        circleSphereCollider = CircleIcon.GetComponent<SphereCollider>();
        anim = CircleIcon.GetComponent<Animator>();
        meshRend = GetComponent<MeshRenderer>();
        Destroy(meshRend);
    }

    // Update is called once per frame
    void Update()
    {
        if(Label.transform.position != Cam.WorldToScreenPoint(TextPH.position))
        {
                // Alinging Text
            currentMainObjectPosition = TextPH.position; //transform.position + OffsetAnchorPoint;
            Vector3 nameofPlace = Cam.WorldToScreenPoint(currentMainObjectPosition);
            Label.transform.position = nameofPlace;
        }

       




        //currentPanelPosition = transform.position;// + OffsetPanel;
        //Vector3 panelPlace = Cam.WorldToScreenPoint(currentPanelPosition);
        //Panel.transform.position = panelPlace;



        // Setting Icon in place

        //if (circleSelectable.IsSelected)
        //    IconSelected();

        //else
        //    IconStartOrDeselected();
    }

    void IconStartOrDeselected()
    {
        
        if (isCheckedChanged)
        {
                CircleIcon.transform.position = transform.position + originalCirlcePosition;

            if (InnerPanel.activeInHierarchy)
            {
                InnerCanvas.SetActive(false);
                InnerPanel.SetActive(false);

            }




            circleSphereCollider.center = Vector3.zero;
            anim.SetBool(ISWIDGETSELECTED, false);

            //isCheckedChanged = circleSelectable.IsSelected;
        }


    }


    void IconSelected()
    {
        
        if (!isCheckedChanged)
        {
           
            CircleIcon.transform.position = ExpandedCirclePlaceHolder.position;// + OffsetPointAnimation;
          
            // circleSphereCollider.center = ColliderOffset;
            anim.SetBool(ISWIDGETSELECTED, true);

            //StartCoroutine(WaitForAnimation(1f));

            InnerCanvas.SetActive(true);
            InnerPanel.SetActive(true);

            //isCheckedChanged = circleSelectable.IsSelected;
        }




    }

    public void CheckedSwitcher()
    {
        IconStartOrDeselected();
        //circleSelectable.IsSelected = false;

    }

    //IEnumerator WaitForAnimation(float time)
    //{
    //    yield return new WaitForSeconds(time);
    //    Panel.SetActive(!Panel.activeInHierarchy);
    //}
}
