using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControoller : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody rb;       //Rigidbody 선언
    private Transform Player;   // 플레이어 위치 가져오기 위해 선언


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(Player.position,transform.position)>5.0f)
        {
            Vector3 direction = (Player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);


        }
    }
}
