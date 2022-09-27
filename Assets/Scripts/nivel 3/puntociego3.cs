using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puntociego3 : MonoBehaviour
{
	Distancia dist;	
	public float Acierto;
	public GameObject puntociego1;
     void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("punto ciego");
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
		RaycastHit hit;
		Debug.Log(puntociego1.GetComponent<Collider>().Raycast(ray, out hit, 100f));
		Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
		if (other.tag == "Player") 
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				SceneManager.LoadScene("nivelfail3");
			}
		}
		
	}	
}
