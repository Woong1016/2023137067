using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public Vector2 initialPos;  //마우스는 화면인 X,Y포지션만 있기 때문에 Vector2
    public GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

     void Update()
    {
    if(Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0))   Calculate  (Input.mousePosition);
    }
    void Calculate(Vector3 finalPos)
    {
        float disX = Mathf.Abs(initialPos.x - finalPos.x);
        float disY = Mathf.Abs(initialPos.y - finalPos.y);

        if (disX> 0 || disY >0)
        {
            if(disX >disY)
            {
                if(initialPos.x > finalPos.x)
                {
                 character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);

                }
                else
                {

                    character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }

            }
            else
            {
                if (initialPos.y > finalPos.y)
                {

                    character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }
                else
                {

                    character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }






            }








        }

    }
}
