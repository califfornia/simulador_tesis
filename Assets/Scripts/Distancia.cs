using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distancia : MonoBehaviour
{
    // Start is called before the first frame update
    public float Porcentaje;
    
    public static Distancia distancia;

     void Awake()
    {       
        
        if(distancia== null){
            distancia=this;
            DontDestroyOnLoad(gameObject);
        }
        else if(distancia != this){
            Destroy(gameObject);
        }
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cargar();
    }
    public void Guardar(float s)
    {   
       
        Porcentaje = s;
    }
     public float Cargar()
    {
        return Porcentaje;
    }
}


