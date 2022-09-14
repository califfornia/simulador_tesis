using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
   public float cuentareg = 15;
   public Text textoTimer;
   public GameObject pasar;
   public GameObject nopasar;
   public GameObject player;
   
    void Update()
    {
		cuentareg -= Time.deltaTime;
		textoTimer.text = "" + cuentareg.ToString("f0");
		
		if (cuentareg <0)
			{
				if(pasar)
				{
					CambiarEscena();
				}
				
				
			}
    }
	
	void CambiarEscena()
	{		
		 SceneManager.LoadScene("nivel2pass");
	}
	void fail()
	{
		SceneManager.LoadScene("nivelfail");
	}
}
