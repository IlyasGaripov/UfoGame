using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldController : MonoBehaviour {

    public Game game;

    int health = 1;
    public string color;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.tag);

        if (other.tag == "RedBullet" && color == "red")
        {
            
            Destroy(other.gameObject);
        }
        

        else if (other.tag == "BlueBullet" && color == "blue")
        {
            Debug.Log("Fine");
            Destroy(other.gameObject);
        }


        else if (other.tag == "GreenBullet" && color == "green")
        {
            Debug.Log("Fine");
            Destroy(other.gameObject);
        }



        else if (other.tag == "YellowBullet" && color == "yellow")
        {
            Debug.Log("Fine");
            Destroy(other.gameObject);
        }

        else {
            Debug.Log(other.gameObject.tag);    
            Destroy(this.gameObject);
            game.ReloadGame();
        }
    }

    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame
	void Update () {
		
	}
}
