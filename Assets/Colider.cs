using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colider : MonoBehaviour
{
    ParticleSystem particulas;
     
    void Start() {
        particulas = GetComponent<ParticleSystem>();
     }
	void OnTriggerEnter (Collider other)
	{
		
		particulas.Stop(); 
	}

    	void OnTriggerExit (Collider other)
	{
		
		particulas.Play(); 
	}	
		
}
