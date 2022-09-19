// CameraController.cs
using UnityEngine;

// プレイヤー追従カメラ
public class CameraController : MonoBehaviour {
    [SerializeField] private float sensitiveRotate = 1.0f;

    private float rotateX = 0.0f;
    private float rotateY = 0.0f;

    void Start ()
    {
    }

    void Update ()
    {
        rotateX += Input.GetAxis("Mouse X") * sensitiveRotate;
        rotateY += Input.GetAxis("Mouse Y") * sensitiveRotate;
        if (rotateY >= 65) rotateY = 65;
        if (rotateY <= -65) rotateY = -65;
        Debug.Log(rotateY);
        transform.rotation = Quaternion.Euler(-rotateY, rotateX, 0.0f);
    }
}