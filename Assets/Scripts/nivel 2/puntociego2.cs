using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puntociego2 : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("punto ciego");
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
		RaycastHit hit;
		Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
		if (other.tag == "Player") 
		{
			if (Input.GetKeyDown(KeyCode.F)||Input.GetButtonDown("Submit"))
			{
				SceneManager.LoadScene("nivelfail2");
			}
		}
		
	}	
}
