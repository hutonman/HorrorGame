// CameraController.cs
using UnityEngine;

// プレイヤー追従カメラ
public class CameraController : MonoBehaviour {
    public int rotationSensitivity = 1;

    private float rotateX = 0.0f;
    private float rotateY = 0.0f;

    void Start ()
    {
    }

    void Update ()
    {
        rotateX += Input.GetAxis("Mouse X") * rotationSensitivity;
        rotateY += Input.GetAxis("Mouse Y") * rotationSensitivity;
        if (rotateY >= 65) rotateY = 65;
        if (rotateY <= -65) rotateY = -65;
        Debug.Log(rotateY);
        transform.rotation = Quaternion.Euler(-rotateY, rotateX, 0.0f);
    }
}