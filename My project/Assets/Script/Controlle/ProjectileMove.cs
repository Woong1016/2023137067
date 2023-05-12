using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;// �߻�ü ���⼺ ����
   

    public enum BULLETTYPE
    {
        PLAYER,
        ENEMY
    }

    public BULLETTYPE bulletType = BULLETTYPE.PLAYER;
    public void FixedUpdate()//�̵����� �Լ�
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);//�浹�� �Ͼ�� �̸��� �����´�

        if (collision.gameObject.name == "wall")
        {
            GameObject temp = this.gameObject;//�� �ڽ��� �����ͼ� Temp�� �Է��Ѵ�
            Destroy(temp);//��ٷ� �ı��Ѵ�
        }


        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;//�� �ڽ��� �����ͼ� Temp�� �Է��Ѵ�
            Destroy(temp);//��ٷ� �ı��Ѵ�
        }
    }


    private void OnTriggerEnter(Collider other)     
    {
        if (other.gameObject.tag == "wall")            
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
                

        }

       

        
        if(other.gameObject.tag=="Monster"&& bulletType == BULLETTYPE.PLAYER)
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            other.gameObject.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            GameObject temp = this.gameObject;
            Destroy(temp);


                
                
        }

        if (other.gameObject.tag == "Player" && bulletType == BULLETTYPE.PLAYER)
        {
            other.gameObject.GetComponent<PlayerControlle>().Player_Damaged(1);
            GameObject temp = this.gameObject;
            Destroy(temp);




        }
    }

}

  