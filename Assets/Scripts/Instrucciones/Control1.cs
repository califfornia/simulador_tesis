using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control1 : MonoBehaviour
{
    public GameObject botonInput;
    public GameObject botonInput2;
    botonManager Cambiador;
    cambioEscenas manager;
    TestSave input;
    public string escena;
    public Text name;
    // Start is called before the first frame update
    void Start()
    {
        Cambiador = FindObjectOfType<botonManager>();
        manager = FindObjectOfType<cambioEscenas>();
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
            else if (botonInput2.activeSelf){
            Debug.Log("Submit");
            manager.LoadScene (escena);
            input.SaveUserName(name);


            }

            // Fire !!
        }
        
    }
}
