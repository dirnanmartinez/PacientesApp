using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ServerModels;
using TMPro;
using System.Text;
using PlayFab.ClientModels;
using ItemInstance = PlayFab.ServerModels.ItemInstance;
using GetUserInventoryRequest = PlayFab.ServerModels.GetUserInventoryRequest;
using GetUserInventoryResult = PlayFab.ServerModels.GetUserInventoryResult;
using DG.Tweening;
using System.Linq;

//PARA PRUEBAS
using UnityEngine.Networking;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour
{

    public event Action OnLoading;

    public event Action OnLogin;
    public event Action OnRegister;
    public event Action onDescActivity;
    public event Action onAsistenteInfo;
    public event Action onAsistenteStartPaso;
    public event Action onRegisterSpace;
    public event Action onRegisterSpaceAccion;
    public event Action onNextPaso;
    public event Action onEndActivity;
    public event Action onEndActivityTimer0;
    

    public event Action onBoxObjetosOpen;
    public event Action onARPositionObject;
    public event Action OnItemsMenu;
    public event Action OnARPosition;


    [Header("Pacient")]
    [SerializeField] private GameObject loginCanvas;
    [SerializeField] private GameObject optionsCanvas;
    [SerializeField] private GameObject descActivityCanvas;
    [SerializeField] private GameObject endActivityCanvas;

    [Header("Login")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    [Header("Register")]
    public Text messageInfo;
    public InputField emailInputRegister;
    public InputField password1InputRegister;
    public InputField password2InputRegister;

    [Header("Descripcion Actividad")]
    public Text nameAct;
    public Text maxPuntuacion;
    string maxPunt = "0";
    public Text creadorAct;
    public Text descAct;
    public Text pasosAct;
    public Text timeAct;

    [Header("Asistente Info ")]
    public Text nameActInfo;

    [Header("StartPaso")]
    public Text namePaso1;
    public Text bocadilloNombreAct;
    public Text bocadilloPrimerPaso;
    public Text bocadilloNombreUbicacion;
    public Text bocadilloObjetosPaso1;

    [Header("Register space")]
    public Text espacioRegister;

    [Header("Realizar Paso")]
    public Text accionRealizar;


    [Header("Next Paso")]
    public Text actNamee;
    public Text feedback;

    [Header("End Activity")]
    public Text bocadilloNombreActFin;
    public Text actFinName;
    public Text timeFin;
    public Text puntuacionFin;
    public Text feedbackFin;

    [Header("End ActivityTimer0")]
    public Text bocadilloNombreActFinTimer0;
    public Text actFinNameTimer0;
    public Text feedbackFinTimer;

    #region azure impletation

    [SerializeField] private ServerManager serverManager;
    public ServerManager ServerManager => serverManager;
    public event Action OnLocalLoginSuccess;
    public event Action<GameObject> OnARObjectPlaced;

    public string CurrentARObjectNameOnStep;
    public string CurrentAnchorIDToFind;
    public string CurrentUserOnApp;

    public int CurrentStepForSaveAnchor;

    #endregion

    #region texts
    [Header("Datos de la actividad para mostrar en PRACTITIONER")]
    [SerializeField] private Text _tittle0;
    [SerializeField] private Text _tittle1;
    [SerializeField] private Text _tittle2;
    [SerializeField] private Text _tittle3;
    [SerializeField] private Text _tittle4;
    [SerializeField] private Text _tittle5;
    [SerializeField] private Text _tittle6;
    [SerializeField] private Text _tittle7;
    [SerializeField] private Text _tittle8;
    [SerializeField] private Text _tittle9;
    [SerializeField] private Text _tittle10;
    [SerializeField] private Text _tittle11;
    [SerializeField] private Text _tittle12;
    [SerializeField] private Text _tittle13;
    [SerializeField] private Text _tittle14;
    [SerializeField] private Text _tittle15;
    [SerializeField] private Text _tittle16;
    [SerializeField] private Text _tittle17;
    [SerializeField] private Text _tittle18;
    [SerializeField] private Text _tittle19;
    [SerializeField] private Text _tittle20;
    [SerializeField] private Text _tittle21;
    [SerializeField] private Text _tittle22;
    [SerializeField] private Text _tittle23;
    [SerializeField] private Text _tittle24;
    [SerializeField] private Text _tittle25;
    [SerializeField] private Text _tittle26;
    [SerializeField] private Text _tittle27;
    [SerializeField] private Text _tittle28;
    [SerializeField] private Text _tittle29;
    [SerializeField] private Text _tittle30;
    [SerializeField] private Text _tittle31;
    [SerializeField] private Text _tittle32;
    [SerializeField] private Text _tittle33;
    [SerializeField] private Text _tittle34;
    [SerializeField] private Text _tittle35;
    [SerializeField] private Text _tittle36;
    [SerializeField] private Text _tittle37;
    [SerializeField] private Text _tittle38;
    [SerializeField] private Text _tittle39;
    [SerializeField] private Text _tittle40;
    [SerializeField] private Text _tittle41;
    [SerializeField] private Text _tittle42;
    [SerializeField] private Text _tittle43;
    [SerializeField] private Text _tittle44;
    [SerializeField] private Text _tittle45;
    [SerializeField] private Text _tittle46;
    [SerializeField] private Text _tittle47;
    [SerializeField] private Text _tittle48;
    [SerializeField] private Text _tittle49;

    [SerializeField] private Text _description0;
    [SerializeField] private Text _description1;
    [SerializeField] private Text _description2;
    [SerializeField] private Text _description3;
    [SerializeField] private Text _description4;
    [SerializeField] private Text _description5;
    [SerializeField] private Text _description6;
    [SerializeField] private Text _description7;
    [SerializeField] private Text _description8;
    [SerializeField] private Text _description9;
    [SerializeField] private Text _description10;
    [SerializeField] private Text _description11;
    [SerializeField] private Text _description12;
    [SerializeField] private Text _description13;
    [SerializeField] private Text _description14;
    [SerializeField] private Text _description15;
    [SerializeField] private Text _description16;
    [SerializeField] private Text _description17;
    [SerializeField] private Text _description18;
    [SerializeField] private Text _description19;
    [SerializeField] private Text _description20;
    [SerializeField] private Text _description21;
    [SerializeField] private Text _description22;
    [SerializeField] private Text _description23;
    [SerializeField] private Text _description24;
    [SerializeField] private Text _description25;
    [SerializeField] private Text _description26;
    [SerializeField] private Text _description27;
    [SerializeField] private Text _description28;
    [SerializeField] private Text _description29;
    [SerializeField] private Text _description30;
    [SerializeField] private Text _description31;
    [SerializeField] private Text _description32;
    [SerializeField] private Text _description33;
    [SerializeField] private Text _description34;
    [SerializeField] private Text _description35;
    [SerializeField] private Text _description36;
    [SerializeField] private Text _description37;
    [SerializeField] private Text _description38;
    [SerializeField] private Text _description39;
    [SerializeField] private Text _description40;
    [SerializeField] private Text _description41;
    [SerializeField] private Text _description42;
    [SerializeField] private Text _description43;
    [SerializeField] private Text _description44;
    [SerializeField] private Text _description45;
    [SerializeField] private Text _description46;
    [SerializeField] private Text _description47;
    [SerializeField] private Text _description48;
    [SerializeField] private Text _description49;

    #endregion
    //VARIABLE PARA GUARDAR LAS ACTIVIDADES
    List<Activities> actividades = new List<Activities>();
    List<int> activitiesIds = new List<int>();

    List<Step> stepsInActiviy = new List<Step>();
    Step stepInformation = new Step();
    List<int> stepsIds = new List<int>();
    int stepAux = 0;

    string regUbicacionAntigua = null;


    //Patron Singleton
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    //START DE LA APLICACI???N
    void Start()
    {
        //Llamo a la pantalla de loading
        LoadingMenu();
        //Llamo a collect Actividades
    }

    //MUESTRO PANTALLA DE LOADING
    public void LoadingMenu()
    {
        OnLoading?.Invoke();
        Debug.Log("Loading 0 menu ACTIVATED");
        StartCoroutine(Loadingg());
    }

    IEnumerator Loadingg()
    {
        yield return new WaitForSecondsRealtime(2);
        LoginMenu();
    }

    public void LoginMenu()
    {
        OnLogin?.Invoke();
        Debug.Log("Login menu ACTIVATED");
        messageInfo.text = "";
        emailInputRegister.text = "";
        password1InputRegister.text = "";
        password2InputRegister.text = "";
    }

    public void RegisterMenu()
    {
        Debug.Log("Register menu ACTIVATED");
        OnRegister?.Invoke();
        messageText.text = "";
        emailInput.text = "";
        passwordInput.text = "";
    }

    /*
    public void AAAPruebas()
    {
        //StartCoroutine(CollectActivities());
        //StartCoroutine(CollectActivity2User());
        //StartCoroutine(CollectEntity3D());
        //StartCoroutine(CollectInteractiveSpaces());
        //StartCoroutine(CollectActivitiesById());
        //string owner = "Terapeuta2@uclm.es";
        //StartCoroutine(CollectActivitiesByOwner());
        //StartCoroutine(CollectActivitiesByUser());
        //StartCoroutine(CollectActivity2UserByActivityId());
        StartCoroutine(CollectActivitiesByUser());
        //Debug.Log("FUNCION APAGADA");
    }
    */

    IEnumerator CollectActivitiesByUser()
    {
        string usuario = emailInput.text;
        //string usuario = "marta@uclm.es";


        UnityWebRequest www = UnityWebRequest.Get("https://serviciotfg.azurewebsites.net/api/Activity2User/GetActivitiesAssigned2User?user=" + usuario);
        yield return www.Send();

        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }

        var activitiesByUSer = JsonConvert.DeserializeObject<List<Activities>>(www.downloadHandler.text);

        actividades = activitiesByUSer;

        foreach (var act in actividades)
        {
            activitiesIds.Add(act.activityId);
            
        }

        ActivateOptionsMenu();
    }
    IEnumerator CollectStepsByActivityId()
    {
        int activityId = idActividadSeleccionada;

        UnityWebRequest www = UnityWebRequest.Get("https://serviciotfg.azurewebsites.net/api/Steps/GetSteps?idActivity=" + activityId);
        yield return www.Send();

        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }

        var stepInfo = JsonConvert.DeserializeObject<List<Step>>(www.downloadHandler.text);
        stepsInActiviy = stepInfo;

        foreach (var s in stepsInActiviy)
        {
            stepsIds.Add(s.id);
        }

        InfoActivityComplete();
    }
    IEnumerator GetStepsById()
    {
        int stepId = stepsIds[stepAux];

        UnityWebRequest www = UnityWebRequest.Get("https://serviciotfg.azurewebsites.net/api/Steps/GetStep?id=" + stepId);
        yield return www.Send();

        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }

        var stepInfo = JsonConvert.DeserializeObject<Step>(www.downloadHandler.text);
        stepInformation = stepInfo;

        AsistenteStartPasoMenu();
    }

    #region Azure Methods
    public void ActivityID(int ID)
    {
        ApplicationAnchorsManagerServer.Instance.GetDataFromServer(ID.ToString(), GetTypeServer.Steps);
    }

    #endregion
    public void RegisterButton()
    {
        if (password1InputRegister.text == password2InputRegister.text)
        {
            var request = new RegisterPlayFabUserRequest
            {
                Email = emailInputRegister.text,
                Password = password1InputRegister.text,
                RequireBothUsernameAndEmail = false,
            };
            PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnErrorReg);
        }
        else
        {
            messageInfo.text = "LAS CONTRASE???S NO COINCIDEN";
        }
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageInfo.text = "REGISTRADO CORRECTAMENTE";
    }


    public void PressLoginButton()
    {
        DoLogin(emailInput.text, passwordInput.text);
    }

    public void DoLogin(string email, string pass)
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = email,
            Password = pass
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
    }

    private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Succesful login/account create!!");
        StartCoroutine("CollectActivitiesByUser");

        ApplicationAnchorsManagerServer.Instance.GetDataFromServer(emailInput.text, GetTypeServer.Activities);
        OnLocalLoginSuccess?.Invoke();

        messageText.text = "";

    }

    private void OnError(PlayFabError error)
    {
        Debug.Log("Error while logging account");
        Debug.Log(error.GenerateErrorReport());
        messageText.text = "EMAIL/CONTRASE???A INCORRECTA!! VUELVA A INTENTARLO";
    }

    private void OnErrorReg(PlayFabError error)
    {
        Debug.Log("Error while logging account");
        Debug.Log(error.GenerateErrorReport());
        messageInfo.text = "CONTRASE???AS NO COINCIDEN!! VUELVA A INTENTARLO";
    }


    public void ActivateOptionsMenu()
    {
        Debug.Log("Options menu ACTIVATED");
        StopCoroutine("CollectActivitiesByOwner");

        endActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        loginCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        optionsCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f); //PANEL

        optionsCanvas.transform.GetChild(0).GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f); //TITTLE
        optionsCanvas.transform.GetChild(0).GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f); //INFO
        optionsCanvas.transform.GetChild(0).GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f); //SCROLL
        optionsCanvas.transform.GetChild(0).GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f); //BUTTON
        optionsCanvas.transform.GetChild(0).GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.3f); //CREADOR

        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f); //VIEW
        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f); //SCROLL

        optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        int i = 0;
        int numActividad = 0;

        foreach (var actividad in actividades)
        {
            if (numActividad == 0)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle0.text = actividad.Name;
                _description0.text = actividad.Description;
                i++;
            }
            if (numActividad == 1)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle1.text = actividad.Name;
                _description1.text = actividad.Description;
                i++;
            }
            if (numActividad == 2)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle2.text = actividad.Name;
                _description2.text = actividad.Description;
                i++;
            }
            if (numActividad == 3)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle3.text = actividad.Name;
                _description3.text = actividad.Description;
                i++;
            }
            if (numActividad == 4)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle4.text = actividad.Name;
                _description4.text = actividad.Description;
                i++;
            }
            if (numActividad == 5)
            {
                optionsCanvas.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(i).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
                _tittle5.text = actividad.Name;
                _description5.text = actividad.Description;
                i++;
            }
            numActividad++;
        }

        

        descActivityCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

    }

    public void VolverLogin()
    {
        OnLogin?.Invoke();
        activitiesIds.Clear();
        actividades.Clear();
        messageText.text = "";
        emailInput.text = "";
        passwordInput.text = "";
    }

    int idActividadSeleccionada;
    int activity;

    public void Act1Aux0()
    {
        activity = 0;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectStepsByActivityId");
    }
    public void Act1Aux1()
    {
        activity = 1;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectStepsByActivityId");
    }
    public void Act1Aux2()
    {
        activity = 2;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectStepsByActivityId");
    }
    public void Act1Aux3()
    {
        activity = 3;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectStepsByActivityId");
    }
    public void Act1Aux4()
    {
        activity = 4;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectStepsByActivityId");
    }
    public void Act1Aux5()
    {
        activity = 5;
        idActividadSeleccionada = activitiesIds[activity];
        StartCoroutine("CollectStepsByActivityId");
    }


    public void InfoActivityComplete()
    {

        StopCoroutine("CollectStepsByActivityId");

        nameAct.text = actividades[activity].Name;
        maxPuntuacion.text = maxPunt;
        descAct.text = actividades[activity].Description;
        creadorAct.text = actividades[activity].Owner;
        timeAct.text = actividades[activity].MaxTime.ToString();

        int numStep = 0;
        int aux = 1;
        foreach (var s in stepsInActiviy)
        {
            if (numStep == 0)
            {
                
                if (s.stepDescriptions[0].Description == "string")
                {
                    pasosAct.text = "Paso 1 --> No hay descripcion";
                }
                else
                {
                    pasosAct.text = "Paso 1 --> " + s.stepDescriptions[0].Description;
                }
            }
            else
            {
                if (s.stepDescriptions[0].Description == "string")
                {
                    pasosAct.text = pasosAct.text + "\nPaso " + aux + " --> No hay descripcion";
                }
                else
                {
                    pasosAct.text = pasosAct.text + "\nPaso " + aux + " --> " + s.stepDescriptions[0].Description;
                }
            }

            aux++;
            numStep++;
        }

        onDescActivity?.Invoke();
    }
    public void VolverOptions()
    {   
        stepsInActiviy.Clear();
        stepsIds.Clear();
        ActivateOptionsMenu();
    }

    public void AsistenteInfoMenu()
    {
        onAsistenteInfo?.Invoke();
        Debug.Log("Asistente Info Menu ACTIVATED");
    }

    [SerializeField] Text tiempo;

    private float restante;
    private bool enMarcha;

    public void AsistenteStartPasoAux()
    {
        if (stepAux < stepsIds.Count())
        {
            StartCoroutine("GetStepsById");

            string anchorID = ApplicationAnchorsManagerServer.Instance.steps[stepAux].anchorId;
            Debug.Log("I wil Try to Get anchor for step " + stepAux + " Anchor ID: " + anchorID);
            if (anchorID != "0")
            {
                CurrentARObjectNameOnStep = ApplicationAnchorsManagerServer.Instance.steps[stepAux].stepDescriptions[0].entities[0].entityName;
                ApplicationAnchorsManagerServer.Instance.TryToFindAnchor(anchorID);
            }

            stepAux++;


        }
        else
        {
            Debug.Log("NO HAY MAS PASOS");
            EndActivityMenuControlador();
        }

        if (stepAux == 1)
        {
            restante = actividades[activity].MaxTime;
            enMarcha = true;
        }
        

    }

    void Update()
    {
       
        if (enMarcha == true)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                EndActivityMenuControladorTimer0();
            }
            //int tempMin = Mathf.FloorToInt(restante / 3600); 
            //int tempSeg = Mathf.FloorToInt(restante % 60);

            //tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
            tiempo.text = string.Format("{00:00}", restante);
        }
    }

    public void AsistenteStartPasoMenu()
    {
        StopCoroutine("GetStepsById");

        namePaso1.text = actividades[activity].Name;
        bocadilloNombreAct.text = actividades[activity].Name;
        bocadilloPrimerPaso.text = stepInformation.stepDescriptions[0].Description;
        bocadilloNombreUbicacion.text = stepInformation.InteractiveSpaceName;
        bocadilloObjetosPaso1.text = stepInformation.stepDescriptions[0].entities[0].actions[0].description;

        onAsistenteStartPaso?.Invoke();
      
    }
    public void RegisterSpaceMenu()
    {

        if(regUbicacionAntigua != stepInformation.InteractiveSpaceName)
        {
            espacioRegister.text = stepInformation.InteractiveSpaceName;
            regUbicacionAntigua = stepInformation.InteractiveSpaceName;

            onRegisterSpace?.Invoke();
            Debug.Log("Register Space menu ACTIVATED");
        }
        else
        {
            RegisterSpaceAccion();
        }

        
    }

    public void RegisterSpaceAccion()
    {
        accionRealizar.text = stepInformation.stepDescriptions[0].Description;

        onRegisterSpaceAccion?.Invoke();
        
    }
    public void NextPasoMenuControlador()
    {
        actNamee.text = actividades[activity].Name;
        feedback.text = stepInformation.stepDescriptions[0].entities[0].actions[0].feedbackMessage;
        onNextPaso?.Invoke();
    }
    public void EndActivityMenuControlador()
    {
        enMarcha = false;

        float timeInicial = actividades[activity].MaxTime; //700
        Debug.Log("timeInicial --> " + timeInicial);
        float timeFinn = restante;
        Debug.Log("timeFinn --> " + timeFinn);

        float calculate = (timeFinn * 10) / timeInicial;


        Debug.Log("calculate --> " + calculate);

        bocadilloNombreActFin.text = actividades[activity].Name;
        actFinName.text = actividades[activity].Name;
        timeFin.text = (timeInicial - timeFinn).ToString() + "segundos";


        if (timeInicial > timeFinn)
        {
            feedbackFin.text = actividades[activity].FinalMessageOK;

            if (calculate > 6.9)
            {
                puntuacionFin.text = "10";
            }
            else if (calculate > 4.9)
            {
                puntuacionFin.text = "7";
            }
            else if (calculate > 2.9)
            {
                puntuacionFin.text = "5";
            }
            else
            {
                puntuacionFin.text = "3";
            }
        }
        else
        {
            feedbackFin.text = actividades[activity].FinalMessageError;
            puntuacionFin.text = "0";
        }

        maxPunt = puntuacionFin.text;

        onEndActivity?.Invoke();
    }
    public void EndActivityMenuControladorTimer0()
    {

        enMarcha = false;

        bocadilloNombreActFinTimer0.text = actividades[activity].Name;
        actFinNameTimer0.text = actividades[activity].Name;
        feedbackFinTimer.text = actividades[activity].FinalMessageError;

        maxPunt = "0";

        onEndActivityTimer0?.Invoke();
    }

    public event Action Exit;
    public void SalirDoActivity()
    {
        stepAux = 0;
        stepsIds.Clear();
        stepsInActiviy.Clear();
        regUbicacionAntigua = null;

        Exit?.Invoke();
        ApplicationAnchorsManagerServer.Instance.DeleteARObjects();
        StartCoroutine("CollectActivitiesByUser");
        //StartCoroutine("CollectStepsByActivityId");
        //InfoActivityComplete();
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    
    public void BoxObjetosOpenMenu()
    {

        //objetoAColocar.text = stepInformation.stepDescriptions[0].entities[0].entityName;

        onBoxObjetosOpen?.Invoke();
        Debug.Log("Box Objetos Open menu ACTIVATED");
    }
    public void ARPositionObjectMenu()
    {
        onARPositionObject?.Invoke();
        Debug.Log("AR Position Object menu ACTIVATED");
    }
    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Item menu ACTIVATED");
    }
    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position ACTIVATED");
    }

    
}



