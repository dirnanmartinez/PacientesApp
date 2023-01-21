using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AutoLogin : MonoBehaviour
{
    [SerializeField] private InputField login;
    [SerializeField] private InputField pass;
    // Start is called before the first frame update
    void Start()
    {
        login.text = "marta@uclm.es";
        pass.text = "123456";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
