using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControoller : MonoBehaviour
{
    public float speed = 5.0f;
    public float roationSpeed = 1.0f;

    public GameObject bulletPrefeb;
    public GameObject enemyPivot;

    public Transform firePoint;
    public float fireRate = 1.0f;
    public float nextFireTime;

    private Rigidbody rb;       //Rigidbody ����
    private Transform Player;   // �÷��̾� ��ġ �������� ���� ����


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Player != null)
        {
            if (Vector3.Distance(Player.position, transform.position) > 1.0f)
            {
                Vector3 direction = (Player.position - transform.position).normalized;
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);


            }
            //��žȸ��
            Vector3 targetDirection = (Player.position - enemyPivot.transform.position).normalized;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            enemyPivot.transform.rotation = Quaternion.Lerp(enemyPivot.transform.rotation, targetRotation, roationSpeed * Time.deltaTime);

            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1.0f / fireRate;
                GameObject temp = (GameObject)Instantiate(bulletPrefeb, firePoint.position, firePoint.rotation);
                temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
                temp.GetComponent<ProjectileMove>().bulletType = ProjectileMove.BULLETTYPE.ENEMY;
            }
        }
            


        
    }
}
