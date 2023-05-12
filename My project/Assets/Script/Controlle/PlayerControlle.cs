using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlle : MonoBehaviour
{
    public float moveSpeed = 1.0f;      //이동 속도 변수선언
    public GameObject PlayerPivot;  //플레이어 피봇 선언
        
     Camera viewCamera;             //카메라 정보값을 가져오기 위해 선언
    Vector3 velocity;          //이동방향 벡터 값 선언
    public ProjectileController projectileController;

    public int Player_hp = 20;
    public void Player_Damaged(int damage)
    {
        Player_hp -= damage;
        if (Player_hp <= 0)
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;       //주사용 카메라 입력
    }

    // Update is called once per frame
    void Update()
    {   // 모니터 2D ->인게임 3D좌표 변환 (마우스가 3D 상에 어디에 있는지)
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        //바라볼 위치를 계산하기 위해서 오브젝트 Y축 좌표를 설정 (바닥은 x,z축)
        Vector3 targetPostion = new Vector3(mousePos.x, transform.position.y, mousePos.z);
        //받아온 피봇이 마우스를 보게 한다.
        PlayerPivot.transform.LookAt(targetPostion, Vector3.up);
        //w,a,s,d나 화살표 이동 or 지원하는 이동입력 도구 (Horizontal, Vertical
        
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input .GetAxis("Vertical")).normalized * moveSpeed;

        if(Input .GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }
    }
    private void FixedUpdate()

    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position   +   velocity*Time.fixedDeltaTime);
        //GetComprnet -> 소스가 있는 게임 오브젝트에서 <> 안에 있는 컴포넌트를 접근
        //접근을 한 후에 계산 된 이동위치 값을 MovePoistion 함수에 적용
    }


}
