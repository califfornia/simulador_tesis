using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class cambioEscenas : MonoBehaviour
{
    public void LoadScene (string sceneName){
		
		SceneManager.LoadScene(sceneName);
	}

	
}
