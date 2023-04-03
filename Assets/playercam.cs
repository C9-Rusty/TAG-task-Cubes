using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercam : MonoBehaviour
{
    float Xrotation = 0f;
    public float MouseSens = 200f;
    public Transform Playermovement;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation,-90f,90f);
        transform.localRotation = Quaternion.Euler(Xrotation,0f,0f);
        Playermovement.Rotate(Vector3.up*mouseX);
    }
}
