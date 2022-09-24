using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puntociego: MonoBehaviour
{
	Distancia dist;		
	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("punto ciego");
		if (other.tag == "Player") 
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				dist = FindObjectOfType<Distancia>();
				dist.Guardar(Vector3.Distance(other.transform.position,gameObject.transform.position));
            	SceneManager.LoadScene("nivelfail");
			}
		}
		
	}
}
