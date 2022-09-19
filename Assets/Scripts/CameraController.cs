// CameraController.cs
using UnityEngine;


// プレイヤー追従カメラ
public class CameraController : MonoBehaviour {
    public int rotationSensitivity = 1;

    static int MaxAngle = 65;
    
    private float rotateX = 0.0f;
    private float rotateY = 0.0f;

    void Update ()
    {
        //カーソル非表示＆ロック
        Cursor.lockState = CursorLockMode.Locked;

        //マウスでのカメラ操作
        rotateX += Input.GetAxis("Mouse X") * rotationSensitivity;
        rotateY += Input.GetAxis("Mouse Y") * rotationSensitivity;
        if (rotateY >= MaxAngle) rotateY = MaxAngle;
        if (rotateY <= -MaxAngle) rotateY = -MaxAngle;
        transform.rotation = Quaternion.Euler(-rotateY, rotateX, 0.0f);
    }
}