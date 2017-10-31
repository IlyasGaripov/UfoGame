﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    public Color thisColor;

    MeshRenderer thisMesh;
    public Transform bulletSpawn;
    
    public GameObject bulletPrefab;

    public float speed;
    public float fireRate;
    public int bulletDirection;

    // Use this for initialization
    void Start () {
        //Thi = GetComponent<Material>();
        thisMesh = GetComponent<MeshRenderer>();
        thisMesh.material.color = thisColor;
        InvokeRepeating("Fire", 1f,fireRate);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        //bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
        bullet.GetComponent<Rigidbody>().velocity = new Vector3(bulletDirection*speed, 0, 0);
        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2f);
    }

}
