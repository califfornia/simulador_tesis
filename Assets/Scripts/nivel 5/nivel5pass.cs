using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nivel5pass : MonoBehaviour
{
   public float cuentareg = 15;
   //public Text textoTimer;
	Distancia dist;	
	public float Acierto;
	public GameObject puntociego1;
	public GameObject puntociego2;
	
     void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("esta pasando");
		cuentareg -= Time.deltaTime;

		//textoTimer.text = "" + cuentareg.ToString("f0");
		if (other.tag == "Player") 
		{
			
			Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
			RaycastHit hit;
			Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
			Debug.Log(Physics.Raycast(ray, out hit));
			if (cuentareg <0)
			{
				dist = FindObjectOfType<Distancia>();
				if (Physics.Raycast(ray, out hit))
				{
					Debug.Log("Raycast");
					if(hit.distance > 8 ){
						Acierto=1f;
						Debug.Log ("Porcentaje de Acierto: " +  (Acierto*100).ToString() + "%");
					}
					if(hit.distance < 7 &&  hit.distance > 5){
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
			
				SceneManager.LoadScene("simcompletado");
				
			}

			
			//timer.SetActive(true);
		}
	
			/*if (Input.GetKeyDown(KeyCode.F))
			{
            SceneManager.LoadScene("nivel2pass");
			}*/
				
	}	
}
