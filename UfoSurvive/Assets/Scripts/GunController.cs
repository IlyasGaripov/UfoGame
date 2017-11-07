using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {


    public Color thisColor;
    public Color prefabColor;

    public string color;

    public FieldController fc;

    MeshRenderer thisMesh;
    MeshRenderer prefabMesh;

    public Transform bulletSpawn;
    
    public GameObject bulletRedPrefab, bulletBluePrefab, bulletGreenPrefab, bulletYellowPrefab;

    public float speed;
    public float fireRate;
    public int bulletDirection;
    private Rigidbody thisRigidBody;

    public float dieTime;



    // Use this for initialization
    void Start () {
        //Thi = GetComponent<Material>();
       // thisMesh = GetComponent<MeshRenderer>();
     
       // thisMesh.material.color = thisColor; change mesh color
        InvokeRepeating("Fire", 0.125f,fireRate);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        GameObject go;

        if (color == "red")
        {
            go = (GameObject)Instantiate(bulletRedPrefab, bulletSpawn.position, bulletSpawn.rotation);

            prefabMesh = go.GetComponent<MeshRenderer>();
            prefabMesh.material.color = prefabColor;
            go.transform.SetParent(transform);
            go.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletDirection * speed);
            // Destroy the bullet after 2 seconds
            Destroy(go, dieTime);
        }
        else if (color == "blue")
        {
            go = (GameObject)Instantiate(bulletBluePrefab, bulletSpawn.position, bulletSpawn.rotation);

            prefabMesh = go.GetComponent<MeshRenderer>();
            prefabMesh.material.color = prefabColor;
            go.transform.SetParent(transform);
            go.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletDirection * speed);
            // Destroy the bullet after 2 seconds
            Destroy(go, dieTime);
        }
        else if (color == "green")
        {
            go = (GameObject)Instantiate(bulletGreenPrefab, bulletSpawn.position, bulletSpawn.rotation);

            prefabMesh = go.GetComponent<MeshRenderer>();
            prefabMesh.material.color = prefabColor;
            go.transform.SetParent(transform);
            go.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletDirection * speed);
            // Destroy the bullet after 2 seconds
            Destroy(go, dieTime);
        }
        else if (color == "yellow")
        {
            go = (GameObject)Instantiate(bulletYellowPrefab, bulletSpawn.position, bulletSpawn.rotation);

            prefabMesh = go.GetComponent<MeshRenderer>();
            prefabMesh.material.color = prefabColor;
            go.transform.SetParent(transform);
            go.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletDirection * speed);
            // Destroy the bullet after 2 seconds
            Destroy(go, dieTime);
        }


        // Add velocity to the bullet
        //bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

    }


}
