using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
    public Game game;

    private bool rotating = true;
    public float speed;
    public float secondSpeed;
    private int angle;
    private bool canMoveLeft,canMoveRight = true;
    private bool onPressed = false;


    public float smoothing;
    private Vector3 normalizeDirection;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            Debug.Log("GG");
            game.ReloadGame();
        }
    }

    public void Move(int direct)
    {
        transform.Translate(secondSpeed * direct*Time.deltaTime, 0, 0);
    }

    // Use this for initialization
    void Start() {
    
    }

    // Update is called once per frame
    void Update() {
      //  if (Input.GetKey(KeyCode.W))
      //  {
            transform.Translate(new Vector3(0, 0, speed));
      //  }
        //transform.Translate(new Vector3(0, 0, 1));
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1));
        }

        if(Input.GetKey(KeyCode.A))
        {
            Move(-1);
        }
        if(Input.GetKey(KeyCode.D))
        {
            Move(1);
        }
            
    }


}
