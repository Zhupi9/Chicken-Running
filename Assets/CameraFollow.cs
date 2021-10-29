using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform chicken;
    public Vector3 offset;

    public float moveSpeed = 60f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = chicken.position + offset;
        Vector3 angle = Vector3.zero;

        angle.x = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime;
        angle.y = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime;
        angle.z = transform.rotation.z;
        transform.localEulerAngles = angle;

    }
}
