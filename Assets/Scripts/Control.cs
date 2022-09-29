using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    cambioEscenas Cambiador;
    public string escena;
    // Start is called before the first frame update
    void Start()
    {
       Cambiador = FindObjectOfType<cambioEscenas>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1");
            // Fire !!
        }
        if(Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Fire2");
            // Fire !!
        }
        if(Input.GetButtonDown("Fire3"))
        {
            Debug.Log("Fire3");
            // Fire !!
            Cambiador.LoadScene (escena);
        }
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
            
            // Fire !!
        }
        if(Input.GetButtonDown("Submit"))
        {
            Debug.Log("Submit");
            //Cambiador.LoadScene (escena);
            // Fire !!
        }
        if(Input.GetButtonDown("Cancel"))
        {
            Debug.Log("Cancel");
            Application.Quit();
            // Fire !!
        }
    }
}
