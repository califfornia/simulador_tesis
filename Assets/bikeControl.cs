using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeControl : MonoBehaviour
{
	  public float speed;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
		
		Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
        transform.position += movementDirection * speed * Time.deltaTime;
    }
}
