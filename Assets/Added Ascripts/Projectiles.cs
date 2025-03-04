using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectiles : MonoBehaviour
{
    public GameObject Projectile;
    public Transform Gun;
    public float BulletSpeed = 50f;
    public float FireRate, NextFire;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= NextFire)
        {
            NextFire = Time.time + 1f / FireRate;
            shoot();
        }
       

    }
    void shoot() 
    {
        GameObject clone = Instantiate(Projectile);
        clone.transform.position = Gun.transform.position;
        transform.LookAt(Player.transform.position, Vector3.right);
        clone.GetComponent<Rigidbody>().AddForce(transform.forward * BulletSpeed);
        Destroy(clone, 20);
    }
    
}
