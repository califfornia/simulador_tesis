using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPC : MonoBehaviour
{
    CharacterController charactarcontroller;

    public float walkSpeed=6.0f;
    public float runSpeed=10.0f;
    public float jumpSpeed=8.0f;
    public float gravity=20.0f;

    public GameObject Camera;
    public GameObject Camerarig;
    public GameObject objeto;

    private Vector3 move = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        charactarcontroller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(charactarcontroller.isGrounded)
        {
                move = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));

                move = transform.TransformDirection(move)*walkSpeed;
                if(Input.GetButton("Fire1"))
                {
                    move.y = jumpSpeed;
                }
                
                if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0 )
                {
                    objeto.transform.rotation=Quaternion.Euler(new Vector3(0,Camera.transform.eulerAngles.y+92,0));
                }
        }

        move.y -= gravity * Time.deltaTime;

        charactarcontroller.Move(move* Time.deltaTime);
        

        
    }
}
