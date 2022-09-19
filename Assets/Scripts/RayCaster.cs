using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray;
        RaycastHit hit;
        UnityEngine.GameObject target;

        if (Input.GetMouseButtonDown(0)) {

            //マウスカーソルの位置からカメラの画像を通してレイを飛ばす
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 1))
            {
                target = hit.collider.gameObject;
                if(target.GetComponent<Clickable>() != null) {
                    target.GetComponent<Clickable>().Clicked(target);
                }
            }
        }
    }
}
