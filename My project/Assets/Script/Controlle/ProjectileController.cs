using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 launchDirection;
    public GameObject Projectile;

    // Start is called before the first frame update
    public void FireProjectile()
    {
        GameObject Temp = (GameObject)Instantiate(Projectile);

        Temp.transform.position = this.gameObject.transform.position;
        Temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;
        Destroy(Temp, 10f);
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
