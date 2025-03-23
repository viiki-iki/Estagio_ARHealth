using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System;
using UnityEngine.Events;


[RequireComponent(typeof(ARRaycastManager))]
[RequireComponent(typeof(ARAnchorManager))]
[RequireComponent(typeof(ARPlaneManager))]
public class PlacementWithDraggingDroppingController : MonoBehaviour
{
    [SerializeField]
    private GameObject placedPrefab;

    [SerializeField]
    private GameObject welcomePanel;

    [SerializeField]
    private Button dismissButton;

    [SerializeField]
    private Button lockButton;

    [SerializeField]
    private Camera arCamera;

    [SerializeField]
    private float defaultRotation = 0;

    private GameObject placedObject;

    private Vector2 touchPosition = default;

    private ARRaycastManager arRaycastManager;
    private ARAnchorManager arAnchorManager;
    private ARPlaneManager arPlaneManager;
   // private ARPlane arPlane;

    private bool isLocked = false;

    private bool onTouchHold = false;

    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private static List<ARAnchor> referencePoints = new List<ARAnchor>();

    [SerializeField]
    private Button um, dois, tres, quatro, cinco;

    //private GameObject orgaoPrefab
    //{
   //     get;set;
   // }

    public GameObject interfaceOrgaos;
    public GameObject intfim;

    public bool orgaoAtivado;
    public bool ativado1;
    public bool final1;
    public bool ativado2;
    public bool final2;
    public bool ativado3;
    public bool final3;
    public bool ativado4;
    public bool final4;
    public bool ativado5;
    public bool final5;

    private GameObject org;
    private GameObject fim;

    private GameObject org1;
    private GameObject c1;
    private GameObject fim1;

    private GameObject org2;
    private GameObject c2;
    private GameObject fim2;

    private GameObject org3;
    private GameObject c3;
    private GameObject fim3;

    private GameObject org4;
    private GameObject c4;
    private GameObject fim4;

    private GameObject org5;
    private GameObject c5;
    private GameObject fim5;

    public GameObject panel;
    public Animator transicao;

    private GameObject animFim;

   // public GameObject int1;
  //  public GameObject int2;

    // private Placement2 lastSelectedObject;

    //[SerializeField]
    //private GameObject teste;

    void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
        arAnchorManager = GetComponent<ARAnchorManager>();
        arPlaneManager = GetComponent<ARPlaneManager>();
        //arPlane = GetComponent<ARPlane>();
        dismissButton.onClick.AddListener(Dismiss);
        //lockbotao.SetActive(false);
        interfaceOrgaos.SetActive(false);
        intfim.SetActive(false);
        orgaoAtivado = false;
        ativado1 = false;
        final1 = false;
        ativado2 = false;
        final2 = false;
        ativado3 = false;
        final3 = false;
        ativado4 = false;
        final4 = false;    
        ativado5 = false;
        final5 = false;

        if (lockButton != null)
        {
            lockButton.onClick.AddListener(Lock);
        }
        if (um != null && dois != null && tres != null && quatro != null && cinco != null)
        {
        um.onClick.AddListener(Botao1); //(() => ChangePrefabSelection("1"));
        dois.onClick.AddListener(Botao2);//(() => ChangePrefabSelection("2"));
        tres.onClick.AddListener(Botao3);//(() => ChangePrefabSelection("3"));
        quatro.onClick.AddListener(Botao4);//(() => ChangePrefabSelection("4"));
        cinco.onClick.AddListener(Botao5);//(() => ChangePrefabSelection("5"));
        }
    }

    private void Start()
    {
        StartCoroutine(Sim());
    }
    IEnumerator Sim()
    {
       // Menu1.SetActive(false);
        panel.SetActive(true);
       // imagem.SetActive(false);

      //  transicao.SetBool("Inicio", true);
       // Menu1.SetActive(true);
        yield return new WaitForSeconds(1f);
      //  transicao.SetBool("Inicio", false);
        panel.SetActive(false);
      //  int1.SetActive(true);
       // yield return new WaitForSeconds(5f);
       // int1.SetActive(false);
        // imagem.SetActive(true);
    }

    private void Botao1()
    {
        //org1 = GameObject.FindWithTag("org1");
        org = GameObject.FindWithTag("org");
        org1 = org.transform.Find("1").gameObject;
        org1.gameObject.SetActive(true); //gameobject
        um.gameObject.SetActive(false); // botao
        ativado1 = true;    //bool
        if (orgaoAtivado == false)
        {           
            orgaoAtivado = true;
        }
        else
        {
            if(final2 == false)
            {
                if (ativado2 == true)
                {
                    org2.gameObject.SetActive(false); //gameobject
                    dois.gameObject.SetActive(true); //botao
                    ativado2 = false; //bool
                }
            }

            if(final3 == false)
            {
                if (ativado3 == true)
                {
                    org3.gameObject.SetActive(false);
                    tres.gameObject.SetActive(true);
                    ativado3 = false;
                }
            }
            
            if(final4 == false)
            {
                if(ativado4 == true)
                {
                    org4.gameObject.SetActive(false);
                    quatro.gameObject.SetActive(true);
                    ativado4 = false;
                }
            }
            
            if(final5 == false)
            {
                if (ativado5 == true)
                {
                    org5.gameObject.SetActive(false);
                    cinco.gameObject.SetActive(true);
                    ativado5 = false;
                }
            }

        }       
    }
    private void Botao2()
    {
        //org2 = GameObject.FindWithTag("org2");
        org = GameObject.FindWithTag("org");
        org2 = org.transform.Find("2").gameObject;
        org2.gameObject.SetActive(true); //gameobject
        dois.gameObject.SetActive(false); // botao
        ativado2 = true;    //bool
        if (orgaoAtivado == false)
        {
            orgaoAtivado = true;
        }
        else
        {
            if (final1 == false)
            {
                if (ativado1 == true)
                {
                    org1.gameObject.SetActive(false); //gameobject
                    um.gameObject.SetActive(true); //botao
                    ativado1 = false; //bool
                }
            }         
            if (final3 == false)
            {
                if (ativado3 == true)
                {
                    org3.gameObject.SetActive(false);
                    tres.gameObject.SetActive(true);
                    ativado3 = false;
                }
            }
            if (final4 == false)
            {
                if (ativado4 == true)
                {
                    org4.gameObject.SetActive(false);
                    quatro.gameObject.SetActive(true);
                    ativado4 = false;
                }
            }
            if (final5 == false)
            {
                if (ativado5 == true)
                {
                    org5.gameObject.SetActive(false);
                    cinco.gameObject.SetActive(true);
                    ativado5 = false;
                }
            }
        }
    }
    private void Botao3()
    {
        //org3 = GameObject.FindWithTag("org3");
        org = GameObject.FindWithTag("org");
        org3 = org.transform.Find("3").gameObject;
        org3.gameObject.SetActive(true); //gameobject
        tres.gameObject.SetActive(false); // botao
        ativado3 = true;    //bool
        if (orgaoAtivado == false)
        {
            orgaoAtivado = true;
        }
        else
        {
            if (final1 == false)
            {
                if (ativado1 == true)
                {
                    org1.gameObject.SetActive(false); //gameobject
                    um.gameObject.SetActive(true); //botao
                    ativado1 = false; //bool
                }
            }
            if (final2 == false)
            {
                if (ativado2 == true)
                {
                    org2.gameObject.SetActive(false); //gameobject
                    dois.gameObject.SetActive(true); //botao
                    ativado2 = false; //bool
                }
            }
            if (final4 == false)
            {
                if (ativado4 == true)
                {
                    org4.gameObject.SetActive(false);
                    quatro.gameObject.SetActive(true);
                    ativado4 = false;
                }
            }
            if (final5 == false)
            {
                if (ativado5 == true)
                {
                    org5.gameObject.SetActive(false);
                    cinco.gameObject.SetActive(true);
                    ativado5 = false;
                }
            }
        }
    }
    private void Botao4()
    {
        //org4 = GameObject.FindWithTag("org4");
        org = GameObject.FindWithTag("org");
        org4 = org.transform.Find("4").gameObject;
        org4.gameObject.SetActive(true); //gameobject
        quatro.gameObject.SetActive(false); // botao
        ativado4 = true;    //bool
        if (orgaoAtivado == false)
        {
            orgaoAtivado = true;
        }
        else
        {
            if (final1 == false)
            {
                if (ativado1 == true)
                {
                    org1.gameObject.SetActive(false); //gameobject
                    um.gameObject.SetActive(true); //botao
                    ativado1 = false; //bool
                }
            }
            if (final3 == false)
            {
                if (ativado3 == true)
                {
                    org3.gameObject.SetActive(false);
                    tres.gameObject.SetActive(true);
                    ativado3 = false;
                }
            }
            if (final2 == false)
            {
                if (ativado2 == true)
                {
                    org2.gameObject.SetActive(false); //gameobject
                    dois.gameObject.SetActive(true); //botao
                    ativado2 = false; //bool
                }
            }
            if (final5 == false)
            {
                if (ativado5 == true)
                {
                    org5.gameObject.SetActive(false);
                    cinco.gameObject.SetActive(true);
                    ativado5 = false;
                }
            }
        }
    }
    private void Botao5()
    {
        //org5 = GameObject.FindWithTag("org5");
        org = GameObject.FindWithTag("org");
        org5 = org.transform.Find("5").gameObject;
        org5.gameObject.SetActive(true); //gameobject
        cinco.gameObject.SetActive(false); // botao
        ativado5 = true;    //bool
        if (orgaoAtivado == false)
        {
            orgaoAtivado = true;
        }
        else
        {
            if (final1 == false)
            {
                if (ativado1 == true)
                {
                    org1.gameObject.SetActive(false); //gameobject
                    um.gameObject.SetActive(true); //botao
                    ativado1 = false; //bool
                }
            }
            if (final3 == false)
            {
                if (ativado3 == true)
                {
                    org3.gameObject.SetActive(false);
                    tres.gameObject.SetActive(true);
                    ativado3 = false;
                }
            }
            if (final4 == false)
            {
                if (ativado4 == true)
                {
                    org4.gameObject.SetActive(false);
                    quatro.gameObject.SetActive(true);
                    ativado4 = false;
                }
            }
            if (final2 == false)
            {
                if (ativado2 == true)
                {
                    org2.gameObject.SetActive(false); //gameobject
                    dois.gameObject.SetActive(true); //botao
                    ativado2 = false; //bool
                }
            }
        }
    }

    private void Dismiss() => welcomePanel.SetActive(false);

    private void Lock()
    {
        isLocked = !isLocked;
       // lockButton.GetComponentInChildren<Text>().text = isLocked ? "Travado" : "Destravado";
        //CreateAnchor(hits[0]);
        //refA.text = $"numero anchores: {anc.Count}";
        if (placedObject != null)
        {
            placedObject.GetComponent<PlacementObject>();
            //.SetOverlayText(isLocked ? "AR Object Locked" : "AR Object Unlocked");
            ARAnchor anchor;
            anchor = placedObject.GetComponent<ARAnchor>();
            //var oldO = arAnchorManager.anchorPrefab;
            //arAnchorManager.anchorPrefab = placedObject;
            //referencePoints. = placedObject.
            if (anchor == null)
            {
                anchor = placedObject.AddComponent<ARAnchor>();
                arAnchorManager.anchorPrefab = placedObject;
                //arAnchorManager.anchorPrefab = anchor;
                //referencePointCount.text = $"anchor count: {referencePoints.Count}, {anchor.nativePtr}";
            }
           // else
           // {
            //    arAnchorManager.anchorPrefab = placedObject;
            //}
            arPlaneManager.enabled = !arPlaneManager.enabled;

            foreach (ARPlane plane in arPlaneManager.trackables)
            {
                plane.gameObject.SetActive(arPlaneManager.enabled);
            }
            // togButton.GetComponentInChildren<Text>().text = arPlaneManager.enabled ?
            //"Desligar plano" : "Ligar plano";

            lockButton.gameObject.SetActive(false);
            interfaceOrgaos.SetActive(true);
            GameObject esq = GameObject.FindWithTag("esq");
            BoxCollider coll = esq.GetComponent<BoxCollider>();
            coll.enabled = false;
        }
        //AnchorContent(placedObject.transform, placedObject);
    }
   // private void AnchorContent(Vector2 position, GameObject content)
   // {
    //}
    // ARAnchor CreateAnchor(in ARRaycastHit hit)
    //{
       // refA.text = $"numero anchores: {anc.Count}";
        //ARAnchor anchor;
       // anchor = placedObject.GetComponent<ARAnchor>();
       // if (anchor == null)
       // {
        //    anchor = placedObject.AddComponent<ARAnchor>();
       // }
        //Debug.Log($"Created regular anchor (id: {anchor.nativePtr}).");
       // return anchor;
    //}
    void Update()
    {
        // do not capture events unless the welcome panel is hidden
        if (welcomePanel.activeSelf)
            return;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = touch.position;

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if (Physics.Raycast(ray, out hitObject))
                {
                    PlacementObject placementObject = hitObject.transform.GetComponent<PlacementObject>();
                    Placement2 lastSelectedObject = hitObject.transform.GetComponent<Placement2>();
                    //float dist = Vector3.Distance(placedObject.transform.position, arCamera.transform.position);

                    if (placementObject != null)
                    {
                        onTouchHold = isLocked ? false : true;
                        //placementObject.SetOverlayText(isLocked ? "AR Object Locked" : "AR Object Unlocked");
                    }
                    if (lastSelectedObject != null)
                    {
                        //if(hitPose.position <= dist)
                        //{
                          //  Placement2[] allOtherObjects = FindObjectsOfType<Placement2>();
                         //   foreach (Placement2 placement2 in allOtherObjects)
                         //   {
                         //       placement2.Selected = placement2 == lastSelectedObject;
                         //   }

                        if (lastSelectedObject.gameObject.CompareTag("1"))
                        {
                            if (lastSelectedObject.Col1 == true )//&& ativado1 == true)
                            {
                            lastSelectedObject.gameObject.SetActive(false);
                                //Destroy(lastSelectedObject.gameObject);
                            final1 = true;
                            ativado1 = false;
                            c1 = GameObject.FindWithTag("c1");
                            c1.gameObject.SetActive(false);
                            fim = GameObject.FindWithTag("fim");
                            fim1 = fim.transform.Find("f1").gameObject;
                            fim1.gameObject.SetActive(true);
                            }
                        }

                        if (lastSelectedObject.gameObject.CompareTag("2"))
                        {
                            if (lastSelectedObject.Col2 )//&& ativado2)
                            {
                            lastSelectedObject.gameObject.SetActive(false);
                            final2 = true;
                            ativado2 = false;
                            c2 = GameObject.FindWithTag("c2");
                            c2.gameObject.SetActive(false);
                            fim = GameObject.FindWithTag("fim");
                            fim2 = fim.transform.Find("f2").gameObject;
                            fim2.gameObject.SetActive(true);
                            }
                        }

                        if (lastSelectedObject.gameObject.CompareTag("3"))
                        {
                            if (lastSelectedObject.Col3)// && ativado3)
                            {
                            lastSelectedObject.gameObject.SetActive(false);
                            final3 = true;
                            ativado3 = false;
                            c3 = GameObject.FindWithTag("c3");
                            c3.gameObject.SetActive(false);
                            fim = GameObject.FindWithTag("fim");
                            fim3 = fim.transform.Find("f3").gameObject;
                            fim3.gameObject.SetActive(true);
                            }
                        }

                        if (lastSelectedObject.gameObject.CompareTag("4"))
                        {
                            if (lastSelectedObject.Col4 )//&& ativado4)
                            {
                            lastSelectedObject.gameObject.SetActive(false);
                            final4 = true;
                            ativado4 = false;
                            c4 = GameObject.FindWithTag("c4");
                            c4.gameObject.SetActive(false);
                            fim = GameObject.FindWithTag("fim");
                            fim4 = fim.transform.Find("f4").gameObject;
                            fim4.gameObject.SetActive(true);
                            }
                        }

                        if (lastSelectedObject.gameObject.CompareTag("5"))
                        {
                            if (lastSelectedObject.Col5 )//&& ativado5)
                            {
                            lastSelectedObject.gameObject.SetActive(false);
                            final5 = true;
                            ativado5 = false;
                            c5 = GameObject.FindWithTag("c5");
                            c5.gameObject.SetActive(false);
                            fim = GameObject.FindWithTag("fim");
                            fim5 = fim.transform.Find("f5").gameObject;
                            fim5.gameObject.SetActive(true);
                            }
                        }
                            
                    }
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                onTouchHold = false;
               // lastSelectedObject.Selected = false;
            }           
        }

        if(final1 && final2 && final3 && final4 && final5)
        {
            StartCoroutine(Fim());
        }
              
        if (arRaycastManager.Raycast(touchPosition, hits,TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;
            
            if (placedObject == null)
            {
                    if (defaultRotation > 0)
                    {
                        placedObject = Instantiate(placedPrefab, hitPose.position, Quaternion.identity);
                        placedObject.transform.Rotate(Vector3.up, defaultRotation);
                    }
                    else
                    {
                        placedObject = Instantiate(placedPrefab, hitPose.position, hitPose.rotation);
                    }  
            }
            else
            {
                if (onTouchHold)
                {
                    placedObject.transform.position = hitPose.position;
                    if (defaultRotation == 0)
                    {
                        placedObject.transform.rotation = hitPose.rotation;
                    }
                }
            }           
        }
    }

    IEnumerator Fim()
    {
        yield return new WaitForSeconds(1f);
        final1 = false;
        final2 = false;
        final3 = false;
        final4 = false;
        final5 = false;
        interfaceOrgaos.SetActive(false);
        intfim.SetActive(true);
        yield return new WaitForSeconds(3f);
     
        GameObject eantes = GameObject.FindWithTag("eantes");
        eantes.gameObject.SetActive(false);

        org = GameObject.FindWithTag("org");
        org.gameObject.SetActive(false);

        fim = GameObject.FindWithTag("fim");
        fim.gameObject.SetActive(false);

        GameObject col = GameObject.FindWithTag("col");
        col.gameObject.SetActive(false);
       
        intfim.SetActive(false);
        yield return new WaitForSeconds(1f);

        GameObject esq = GameObject.FindWithTag("esq");
        animFim = esq.transform.Find("anim").gameObject;
        animFim.SetActive(true);
    }
}
