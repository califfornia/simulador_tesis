using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nivel2pass : MonoBehaviour
{
	Distancia dist;	
	public float Acierto;
	public GameObject puntociego1;
	public GameObject puntociego2;
	public GameObject puntociego3;
    void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("esta pasando");
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
		RaycastHit hit;
		Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
		if (other.tag == "Player") 
		{
			if (Input.GetKeyDown(KeyCode.F)||Input.GetButtonDown("Submit"))
			{
				dist = FindObjectOfType<Distancia>();
				if (puntociego1.GetComponent<Collider>().Raycast(ray, out hit, 100f) || puntociego2.GetComponent<Collider>().Raycast(ray, out hit, 6f)|| puntociego3.GetComponent<Collider>().Raycast(ray, out hit, 6f))
				{
					if(hit.distance > 6 ){
						Acierto=1f;
						Debug.Log ("Porcentaje de Acierto: " +  (Acierto*100).ToString() + "%");
					}
					if(hit.distance < 6 &&  hit.distance > 5){
						Acierto=1f;
						Debug.Log ("Porcentaje de Acierto: " +  (Acierto*100).ToString() + "%");
					}
					else if(hit.distance < 5 &&  hit.distance > 4){
						Acierto=0.8f;
						Debug.Log ("Porcentaje de Acierto: " +  (Acierto*100).ToString() + "%");
						
					}
					else if(hit.distance < 4 &&  hit.distance > 3){
						Acierto=0.6f;
						Debug.Log ("Porcentaje de Acierto: " +  (Acierto*100).ToString() + "%");
						
					}
					else if(hit.distance < 3 &&  hit.distance > 2){
						Acierto=0.4f;
						Debug.Log ("Porcentaje de Acierto: " +  (Acierto*100).ToString() + "%");
						
					}
					else if(hit.distance < 2 &&  hit.distance > 1){
						Acierto=0.2f;
						Debug.Log ("Porcentaje de Acierto: " +  (Acierto*100).ToString() + "%");
						
					}
					else if(hit.distance < 1){
						Acierto=0.0f;
						Debug.Log ("Porcentaje de Acierto: " +  (Acierto*100).ToString() + "%" );
						
					}

					Debug.Log(hit.distance);
					Debug.Log ("el raycast toco");
					dist.Guardar(Acierto);
					//transform.position = ray.GetPoint(100.0f);
				}
            SceneManager.LoadScene("nivel2pass");
			}
		}
		
	}	
}
