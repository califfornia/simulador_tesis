using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fail : MonoBehaviour
{   //public Text textoTimer;
   void OnTriggerEnter (Collider other)
	{
		SceneManager.LoadScene("nivelfail4");
		
	}	
}
