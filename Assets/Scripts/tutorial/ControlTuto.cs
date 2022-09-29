using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTuto : MonoBehaviour
{
    
    instruccionesText Texto;
    // Start is called before the first frame update
    void Start()
    {
        Texto = FindObjectOfType<instruccionesText>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            Texto.CerrarText();
            // Fire !!
        }
    }
}
