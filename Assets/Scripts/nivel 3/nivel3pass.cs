using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nivel3pass : MonoBehaviour
{
     void OnTriggerEnter (Collider other)
	{
		Debug.Log ("entro");
		
	}	
	
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("esta pasando");
		if (other.tag == "Player") 
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
            SceneManager.LoadScene("nivel3pass");
			}
		}
		
	}	
}
