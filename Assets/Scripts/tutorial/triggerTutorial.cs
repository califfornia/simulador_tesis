using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class triggerTutorial : MonoBehaviour
{
	public GameObject señal;
	
	void Start()
	{		
		señal.SetActive(false);
	}
	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("esta pasando");
		if (other.tag == "Player") 
		{
			señal.SetActive(true);
			if (Input.GetKeyDown(KeyCode.F))
			{
            SceneManager.LoadScene("tutorialpass");
			}
		}
		
	}	
}
