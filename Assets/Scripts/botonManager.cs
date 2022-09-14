using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class botonManager : MonoBehaviour
{
	public GameObject botonInput;
	public GameObject botonScene;
	public Text inputText;
	public GameObject inputField;
	
	void Start(){
		
		inputField.SetActive(false);
		botonScene.SetActive(false);
		botonInput.SetActive(true);
	}
	
	public void InputName (){
		
		inputText.text = "Antes de comenzar, ingresa tu nombre y apellido";
		inputField.SetActive(true);
		botonScene.SetActive(true);
		botonInput.SetActive(false);
	}

    public void LoadScene (string sceneName){
		
		SceneManager.LoadScene(sceneName);
	}

	
}
