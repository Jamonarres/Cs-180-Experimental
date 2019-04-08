using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 orientation = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zoff = player.transform.position.z - transform.position.z;
        float xoff = player.transform.position.x - transform.position.x;
        float yoff = player.transform.position.y - transform.position.y;
        float xangle = Mathf.Atan(xoff / zoff) * Mathf.Rad2Deg;
        float yangle = Mathf.Atan(yoff / zoff) * Mathf.Rad2Deg;
        //float dx = xangle - orientation[1];
        //float dy = yangle - orientation[0];
        //Vector3 rot = new Vector3(-dy, dx, 0);
        orientation = new Vector3(-yangle, xangle, 0);
        //transform.Rotate(rot, Space.Self);
        Quaternion q = transform.rotation;
        q.eulerAngles = orientation;
        transform.rotation = q;

    }
}
