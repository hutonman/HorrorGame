using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    public int moveSpeed = 1;
    // 移動速度
    private Vector3 velocity;
    // 移動方向

    public GameObject mainCamera;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //カメラ方向に身体を向ける
        transform.rotation = mainCamera.transform.rotation;

        // 左に移動
        if (Input.GetKey (KeyCode.A)) {
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }
        // 右に移動
        if (Input.GetKey (KeyCode.D)) {
            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }
        // 前に移動
        if (Input.GetKey (KeyCode.W)) {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        // 後ろに移動
        if (Input.GetKey (KeyCode.S)) {
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
        }

    }
}
