using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldController : MonoBehaviour {

    public Game game;

    int health = 1;
    public string color;

    public GameObject shield;

    private void OnTriggerEnter(Collider other)
    {

        //Debug.Log(other.tag);
        if (other.tag == "Bullet" && color == "any")
        {
            Debug.Log("bullet");
            Destroy(other.gameObject);
        }

    }

    public void ActivateShield()
    {
        shield.SetActive(!shield.activeSelf);
    }


    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame
	void Update () {
		
	}
}
