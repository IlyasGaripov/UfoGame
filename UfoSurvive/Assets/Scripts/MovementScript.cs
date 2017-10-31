using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
    private bool rotating = true;
    public float speed;
    private int angle;

    public float smoothing;
    private Vector3 normalizeDirection;

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
    }


}
