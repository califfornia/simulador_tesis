using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class instruccionesText : MonoBehaviour
{
	public GameObject instruccion;
	public Text text_ins;
	public string[] context_text;
	public int position = 0;
	
	public void CambiarTexto()
	{
		text_ins.text = context_text[position];
	}
	
	public void CerrarText()
	{
		position++;
		if (position < context_text.Length)
		{
			text_ins.text = context_text[position];
		}
		else if (position > context_text.Length){
			position = 0;
			instruccion.SetActive(false);
		}
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
