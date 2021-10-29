using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    public Transform chicken_transform;


    CharacterController chicken_ctrl;
    float chicken_speed = 2.0f;
    float rotate_speed = 150.0f;
    Vector3 rot;
    public Animator anmi;

    // Start is called before the first frame update
    void Start()
    {
        chicken_transform = this.transform;
        chicken_ctrl = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float xm = 0, ym = 0, zm = 0;
        
        if (Input.GetKey(KeyCode.W))
        {
            zm += chicken_speed * Time.deltaTime;
            anmi.SetBool("Run", true);
        } 
        else if (Input.GetKey(KeyCode.S)) {
            zm -= chicken_speed * Time.deltaTime;
            anmi.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            chicken_transform.Rotate(0, -Time.deltaTime*rotate_speed, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            chicken_transform.Rotate(0, Time.deltaTime * rotate_speed, 0);
        }
        if(zm==0) anmi.SetBool("Run", false);
        chicken_ctrl.Move(chicken_transform.TransformDirection(new Vector3(xm, ym, zm)));
    }
}
