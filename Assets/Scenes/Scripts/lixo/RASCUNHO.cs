using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RASCUNHO : MonoBehaviour
{
    //ARAnchor referencePoint = arAnchorManager.AddAnchor(hitPose);
    // if (referencePoint == null)
    // {
    //     string errorEntry = "erro em criar anchor\n";
    //     Debug.Log(errorEntry);
    //     debugLog.tag += errorEntry;
    // }
    // else
    // {
    //     referencePoints.Add(referencePoint);
    //     referencePointCount.text = $"anchor count: {referencePoints.Count}";
    // }

    //private void ChangePrefabSelection(string name)
    //{
    //    GameObject orgaoAtual = Resources.Load<GameObject>($"Prefab/{name}");
    //
    //    if (orgaoAtual != null) {
    //        if (orgaoAtivado == false)
    //        {      
    //         orgaoPrefab = orgaoAtual;
    //         orgaoAtivado = true;
    //            switch (name)
    //            {
    //                case "1":
    //                    um.gameObject.SetActive(false);
    //                    ativado1 = true;
    //                    break;
    //                case "2":
    //                    dois.gameObject.SetActive(false);
    //                    ativado2 = true;
    //                    break;
    //                case "3":
    //                    tres.gameObject.SetActive(false);
    //                    ativado3 = true;
    //                    break;
    //                case "4":
    //                    quatro.gameObject.SetActive(false);
    //                    ativado4 = true;
    //                    break;
    //                case "5":
    //                    cinco.gameObject.SetActive(false);
    //                    ativado5 = true;
    //                    break;
    //            }
    //        }
    //        else
    //        {
    //            //orgaoPrefab.gameObject.SetActive(false);
    //            switch (name)
    //            {
    //                case "1":
    //                    //orgaoPrefab = orgaoAtual;
    //                    //orgaoPrefab.gameObject.SetActive(true);
    //                    um.gameObject.SetActive(false);
    //                    ativado1 = true;
    //
    //                    if(ativado2 == true)
    //                    {
    //                        dois.gameObject.SetActive(true);
    //                        ativado2 = false;
    //                    }
    //                    if(ativado3 == true)
    //                    {
    //                        tres.gameObject.SetActive(true);
    //                        ativado3 = false;
    //                    }
    //                    if(ativado4 == true)
    //                    {
    //                        quatro.gameObject.SetActive(true);
    //                        ativado4 = false;
    //                    }
    //                    if (ativado5 == true)
    //                    {
    //                        cinco.gameObject.SetActive(true);
    //                        ativado5 = false;
    //                    }
    //                    break;
    //
    //                case "2":
    //                    orgaoPrefab = orgaoAtual;
    //                    orgaoPrefab.gameObject.SetActive(true);
    //                    dois.gameObject.SetActive(false);
    //                    ativado2 = true;
    //
    //                    if (ativado1 == true)
    //                    {
    //                        um.gameObject.SetActive(true);
    //                        ativado1 = false;
    //                    }
    //                    if (ativado3 == true)
    //                    {
    //                        tres.gameObject.SetActive(true);
    //                        ativado3 = false;
    //                    }
    //                    if (ativado4 == true)
    //                    {
    //                        quatro.gameObject.SetActive(true);
    //                        ativado4 = false;
    //                    }
    //                    if (ativado5 == true)
    //                    {
    //                        cinco.gameObject.SetActive(true);
    //                        ativado5 = false;
    //                    }
    //                    break;
    //
    //                case "3":
    //                    orgaoPrefab = orgaoAtual;
    //                    orgaoPrefab.gameObject.SetActive(true);
    //                    tres.gameObject.SetActive(false);
    //                    ativado3 = true;
    //
    //                    if (ativado2 == true)
    //                    {
    //                        dois.gameObject.SetActive(true);
    //                        ativado2 = false;
    //                    }
    //                    if (ativado1 == true)
    //                    {
    //                        um.gameObject.SetActive(true);
    //                        ativado1 = false;
    //                    }
    //                    if (ativado4 == true)
    //                    {
    //                        quatro.gameObject.SetActive(true);
    //                        ativado4 = false;
    //                    }
    //                    if (ativado5 == true)
    //                    {
    //                        cinco.gameObject.SetActive(true);
    //                        ativado5 = false;
    //                    }
    //                    break;
    //
    //                case "4":
    //                    orgaoPrefab = orgaoAtual;
    //                    orgaoPrefab.gameObject.SetActive(true);
    //                    quatro.gameObject.SetActive(false);
    //                    ativado4 = true;
    //
    //                    if (ativado2 == true)
    //                    {
    //                        dois.gameObject.SetActive(true);
    //                        ativado2 = false;
    //                    }
    //                    if (ativado3 == true)
    //                    {
    //                        tres.gameObject.SetActive(true);
    //                        ativado3 = false;
    //                    }
    //                    if (ativado1 == true)
    //                    {
    //                        um.gameObject.SetActive(true);
    //                        ativado1 = false;
    //                    }
    //                    if (ativado5 == true)
    //                    {
    //                        cinco.gameObject.SetActive(true);
    //                        ativado5 = false;
    //                    }
    //                    break;
    //
    //                case "5":
    //                    orgaoPrefab = orgaoAtual;
    //                    orgaoPrefab.gameObject.SetActive(true);
    //                    cinco.gameObject.SetActive(false);
    //                    ativado5 = true;
    //
    //                    if (ativado2 == true)
    //                    {
    //                        dois.gameObject.SetActive(true);
    //                        ativado2 = false;
    //                    }
    //                    if (ativado3 == true)
    //                    {
    //                        tres.gameObject.SetActive(true);
    //                        ativado3 = false;
    //                    }
    //                    if (ativado4 == true)
    //                    {
    //                        quatro.gameObject.SetActive(true);
    //                        ativado4 = false;
    //                    }
    //                    if (ativado1 == true)
    //                    {
    //                        um.gameObject.SetActive(true);
    //                        ativado1 = false;
    //                    }
    //                    break;
    //            }
    //        }
    //    }
    //        
    //}
}
