using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPass3 : MonoBehaviour
{
    public GameObject botonInput;
    tuto Cambiador;
    TestSave input;
    public string escena;
    // Start is called before the first frame update
    void Start()
    {
        Cambiador = FindObjectOfType<tuto>();
        input = FindObjectOfType<TestSave>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
            Debug.Log(botonInput.activeSelf);
            if(botonInput.activeSelf){
                Cambiador.texto();
            }
            else{
            Debug.Log("Submit");
            Cambiador.LoadScene (escena);
            input.LevelPercent3();
            Cambiador.LoadScene (escena);

            }

            // Fire !!
        }
        
    }
}
