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
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            	RaycastHit hit;
				dist = FindObjectOfType<Distancia>();
				if (gameObject.GetComponent<Collider>().Raycast(ray, out hit, 1f))
				{
					Debug.Log(hit.distance);
					Debug.Log ("el raycast toco");
					//dist.Guardar(Vector3.Distance(other.transform.position,gameObject.transform.position));
					//transform.position = ray.GetPoint(100.0f);
				}
				
            	SceneManager.LoadScene("nivelfail");
			}
		}
		
	}
}
