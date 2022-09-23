using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    TouchScreenKeyboard teclado;
    public InputField campo;
    private string txt;
    // Start is called before the first frame update
    public void OpenKeyboard()
    {
        teclado=TouchScreenKeyboard.Open("",TouchScreenKeyboardType.Default);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(TouchScreenKeyboard.visible ==false && teclado != null){
            
            if(teclado.done){
                campo.text=teclado.text;
                teclado=null;
            }
        }
    }
}
