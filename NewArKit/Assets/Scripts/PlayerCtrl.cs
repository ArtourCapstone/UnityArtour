﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float MouseSensitivity = 100f;

    public Transform playerBody;

    float Xrot = 0f;

    // Start is called before the first frame update
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        Xrot -= mouseY;
        Xrot = Mathf.Clamp(Xrot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(Xrot, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
