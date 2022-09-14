using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tuto : MonoBehaviour
{
	public Text inputText;
	public GameObject title;
	public GameObject botonText;
	public GameObject botonScene;
	
	public void texto()
	{
		inputText.text = "Para los últimos dos ejercicios solo debes seguir el vehículo donde asumas que te está viendo";
		botonText.SetActive(false);
		title.SetActive(false);
		botonScene.SetActive(true);
	}
    // Start is called before the first frame update
    void Start()
    {
        botonText.SetActive(true);
		botonScene.SetActive(false);
    }

	public void LoadScene (string sceneName){
		
		SceneManager.LoadScene(sceneName);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
