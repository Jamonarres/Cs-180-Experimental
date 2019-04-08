using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    public float speed = 15.0f;

    private CharacterController control;
    private Vector3 movement = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        movement = transform.TransformDirection(movement);
        movement = movement * speed;
        control.Move(movement *Time.deltaTime);
    }
}
