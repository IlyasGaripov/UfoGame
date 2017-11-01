using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldController : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.tag);
        if(other.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
