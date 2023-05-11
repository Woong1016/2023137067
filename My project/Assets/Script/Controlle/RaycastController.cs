using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public GameObject Monster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray Cast = Camera.main.ScreenPointToRay(Input.mousePosition);   //화면에서의 2차원 마우스 좌표를 입력해서 3D 카메라에서 Ray를 만드는 함수

            RaycastHit hit;

            if(Physics.Raycast(Cast,out hit))
            {
                if(hit.collider.tag=="Ground")
                {
                    GameObject temp = (GameObject)Instantiate(Monster);
                    temp.transform.position = hit.point+new Vector3(0.0f,1.0f,0.0f);

                }
                

                Debug.Log(hit.collider.name);

                Debug.DrawLine(Cast.origin, hit.point,Color.red,2.0f);
            }



        }
    }
}
