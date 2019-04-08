using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDmovement : MonoBehaviour
{
    private float speed = 3.0f;
    private Vector3 move = Vector3.zero;

    private CharacterController control;
    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        move = transform.TransformDirection(move);
        move = move * speed;
        control.Move(move *Time.deltaTime);
    }
}
