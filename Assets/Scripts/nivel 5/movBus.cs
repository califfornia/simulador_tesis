using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movBus : MonoBehaviour
{
	[SerializeField] Vector3 posInicial;
	//[SerializeField] Vector3 dirDesplazamiento;
	//[SerializeField] [Range(0,1)] float desplazamiento;
	public float speed;
	
    void Start()
    {
		
		//posInicial = transform.position;
    }

   
    void Update()
    {
		this.transform.position = this.transform.position + new Vector3(speed, 0f, 0f);
    }
	
}
