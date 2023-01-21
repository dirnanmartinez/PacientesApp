using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject loadingCanvas;
    [SerializeField] private GameObject loginCanvas;
    [SerializeField] private GameObject registerCanvas;
    [SerializeField] private GameObject descActivityCanvas;
    [SerializeField] private GameObject optionsCanvas;
    [SerializeField] private GameObject asistenteInfoCanvas;
    [SerializeField] private GameObject asistenteStartPasoCanvas; 
    [SerializeField] private GameObject registerSpaceCanvas;
    [SerializeField] private GameObject registerSpaceAccionCanvas;
    [SerializeField] private GameObject nextPasoCanvas;
    [SerializeField] private GameObject endActivityCanvas;
    [SerializeField] private GameObject endActivityCanvasTimer0;


    void Start()
    {
        GameManager.Instance.OnLoading += ActivateLoading;
        GameManager.Instance.OnLogin += ActivateLoginMenu;
        GameManager.Instance.OnRegister += ActivateRegisterMenu;
        GameManager.Instance.onDescActivity += ActivateDescActivityMenu;
        GameManager.Instance.onAsistenteInfo += ActivateAsistenteInfoMenu;
        GameManager.Instance.onAsistenteStartPaso += ActivateAsistenteStartPasoMenu;
        GameManager.Instance.onRegisterSpace += ActivateRegisterSpaceMenu;
        GameManager.Instance.onRegisterSpaceAccion += ActivateRegisterSpaceAccionMenu;
        GameManager.Instance.onNextPaso += ActivateNextPasoCanvas;
        GameManager.Instance.onEndActivity += ActivateEndActivityCanvas;
        GameManager.Instance.onEndActivityTimer0 += ActivateEndActivityCanvasTimer0;
    }

    private void ActivateLoading()
    {
        loadingCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
    private void ActivateRegisterMenu()
    {
        loginCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        registerCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
    private void ActivateLoginMenu()
    {
        loadingCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        loginCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        registerCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        optionsCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

    }
    private void ActivateDescActivityMenu()
    {
        optionsCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        asistenteInfoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        endActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        endActivityCanvasTimer0.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        descActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        
    }
    private void ActivateAsistenteInfoMenu()
    {
        descActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        asistenteInfoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
    private void ActivateAsistenteStartPasoMenu()
    {
        asistenteInfoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        nextPasoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        asistenteStartPasoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        asistenteStartPasoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

    }
    private void ActivateRegisterSpaceMenu()
    {
        asistenteStartPasoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        registerSpaceCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        registerSpaceCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        registerSpaceCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        registerSpaceCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
    private void ActivateRegisterSpaceAccionMenu()
    {
        asistenteStartPasoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        registerSpaceCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        registerSpaceAccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        registerSpaceAccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        registerSpaceAccionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
    private void ActivateNextPasoCanvas()
    {
        registerSpaceAccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceAccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceAccionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        nextPasoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
    private void ActivateEndActivityCanvas()
    {
        nextPasoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        asistenteStartPasoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        endActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
    private void ActivateEndActivityCanvasTimer0()
    {
        registerSpaceCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceAccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceAccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        registerSpaceAccionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        nextPasoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        asistenteStartPasoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        asistenteStartPasoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        endActivityCanvasTimer0.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
}