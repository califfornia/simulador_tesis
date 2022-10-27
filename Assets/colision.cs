using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colision : MonoBehaviour
{
    public string escena;
    // Start is called before the first frame update
	void OnTriggerEnter (Collider other)
	{
		
		SceneManager.LoadScene("escena"); 

	}



}

