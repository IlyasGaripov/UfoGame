using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    public Color thisColor;
    MeshRenderer thisMesh;
    public Rigidbody prefab;
    public Transform cubeEnd;

    // Use this for initialization
    void Start () {
        //Thi = GetComponent<Material>();
        thisMesh = GetComponent<MeshRenderer>();
        thisMesh.material.color = thisColor;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody bulletInst;
            bulletInst = (Rigidbody)Instantiate(prefab, cubeEnd.position, cubeEnd.rotation) as Rigidbody;
            bulletInst.AddForce(cubeEnd.up * 5000);
            // bulletInst.transform.position = new Vector3(-1, 0, 0);
            Destroy(bulletInst, 3);
        }
    }


}
