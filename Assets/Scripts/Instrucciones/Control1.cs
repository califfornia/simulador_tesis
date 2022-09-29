using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control1 : MonoBehaviour
{
    public GameObject botonInput;
    botonManager Cambiador;
    TestSave input;
    public string escena;
    public Text name;
    // Start is called before the first frame update
    void Start()
    {
        Cambiador = FindObjectOfType<botonManager>();
        input = FindObjectOfType<TestSave>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
            Debug.Log(botonInput.activeSelf);
            if(botonInput.activeSelf){
                Cambiador.InputName();
            }
            else{
            Debug.Log("Submit");
            input.SaveUserName(name);
            Cambiador.LoadScene (escena);

            }

            // Fire !!
        }
        
    }
}
