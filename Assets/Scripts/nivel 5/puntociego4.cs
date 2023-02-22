using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puntociego4 : MonoBehaviour
{
	public float cuentareg2 = 60;
   //public Text textoTimer;
   void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{

		//textoTimer.text = "" + cuentareg.ToString("f0");
		if (other.tag == "Player") 
		{
			Debug.Log ("punto ciego");
			cuentareg2 -= Time.deltaTime;
			if (cuentareg2 <0)
			{
			
				SceneManager.LoadScene("nivelfail5");
				
			}

			
			//timer.SetActive(true);
		}

		
	}	
}
