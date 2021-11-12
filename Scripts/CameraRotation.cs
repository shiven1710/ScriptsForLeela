using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    // Start is called before the first frame update
    private float x, y;
    private Vector3 rotateVal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");
        rotateVal = new Vector3(x, y * -1, 0);
        transform.eulerAngles = transform.eulerAngles - rotateVal;
    }
}
