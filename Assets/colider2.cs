using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colider2 : MonoBehaviour
{
    ParticleSystem particulas;
     
    void Start() {
        particulas = GetComponent<ParticleSystem>();
     }
	void OnTriggerEnter (Collider other)
	{
		
		
	}

    	void OnTriggerExit (Collider other)
	{
		
		particulas.Play(); 
	}	
		
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("esta pasando");
        particulas.Stop(); 
		if (other.tag == "Player") 
		{
			if (Input.GetKeyDown(KeyCode.F)||Input.GetButtonDown("Submit"))
			{
				SceneManager.LoadScene("tutorialpass");

			}
		}
		
	}	
}