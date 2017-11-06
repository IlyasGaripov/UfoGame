using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private float bladesRotateSpeed = 350f;

    public GameObject blades;
    public GameObject startPos;
    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        blades.transform.RotateAround(transform.position, transform.forward, Time.deltaTime * bladesRotateSpeed);
    }
}
