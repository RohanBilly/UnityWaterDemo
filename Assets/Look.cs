using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{

    [SerializeField] float minViewDistance = 25f;
    public float mouseSensitivity = 100f;
    [SerializeField] Transform MainCamera;
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, minViewDistance);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        MainCamera.Rotate(Vector3.up * mouseX);
        
    }
}
