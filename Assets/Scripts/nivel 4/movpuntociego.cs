using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movpuntociego : MonoBehaviour
{
	public float cuentareg = 15;
   //public Text textoTimer;
   void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("punto ciego");
		cuentareg -= Time.deltaTime;
		//textoTimer.text = "" + cuentareg.ToString("f0");
		if (other.tag == "Player") 
		{
			if (cuentareg <0)
			{
			
				SceneManager.LoadScene("nivelfail4");
				
			}
			
			//timer.SetActive(true);
		}
		
	}	
}
