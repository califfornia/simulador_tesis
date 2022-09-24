using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class triggerTutorial : MonoBehaviour
{
	Distancia dist;
	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("esta pasando");
		if (other.tag == "Player") 
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				dist = FindObjectOfType<Distancia>();
				dist.Guardar(1f);
				SceneManager.LoadScene("tutorialpass");

			}
		}
		
	}	
}
