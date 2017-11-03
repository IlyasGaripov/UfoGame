using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShield : FieldController {

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.tag);
        if (other.tag == "RedBullet")
        {
            Debug.Log("Fine");
            Destroy(other.gameObject);
        }
        else { Debug.Log("Bad"); }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
