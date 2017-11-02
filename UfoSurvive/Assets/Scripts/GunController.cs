using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    public Color thisColor;
    public Color prefabColor;

    MeshRenderer thisMesh;
    MeshRenderer prefabMesh;

    public Transform bulletSpawn;
    
    public GameObject bulletPrefab;

    public float speed;
    public float fireRate;
    public int bulletDirection;
    private Rigidbody thisRigidBody;

    // Use this for initialization
    void Start () {
        //Thi = GetComponent<Material>();
        thisMesh = GetComponent<MeshRenderer>();
        
        thisMesh.material.color = thisColor;
        InvokeRepeating("Fire", 0.125f,fireRate);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        GameObject go;
        go = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        prefabMesh = go.GetComponent<MeshRenderer>();
        prefabMesh.material.color = prefabColor;
        go.transform.SetParent(transform);


        // Add velocity to the bullet
        //bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
        go.GetComponent<Rigidbody>().velocity = new Vector3(bulletDirection*speed, 0, 0);
        // Destroy the bullet after 2 seconds
        Destroy(go, 1.9f);
    }

}
