using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldsRotateController : MonoBehaviour
{
    public int rotationDirection; // -1 for clockwise
                                       //  1 for anti-clockwise

    public int rotationStep = 5;    // should be less than 90
    public bool rotateFlag = true;
 
    // All the objects with which collision will be checked
    public GameObject[] objectsArray;

    private Vector3 currentRotation, targetRotation;

    public float timeBetweenShots = 0.01f;  // Allow 3 shots per second

    private float timestamp;

    private void rotateObject()
    {
        currentRotation = gameObject.transform.eulerAngles;
        targetRotation.y = (currentRotation.y + (90 * rotationDirection));
        StartCoroutine(objectRotationAnimation());
    }

    IEnumerator objectRotationAnimation()
    {
        // add rotation step to current rotation.
        currentRotation.y += (rotationStep * rotationDirection);
        gameObject.transform.eulerAngles = currentRotation;
        yield return new WaitForSeconds(0);
        if (((int)currentRotation.y >(int)targetRotation.y && rotationDirection < 0) ||  ((int)currentRotation.y < (int)targetRotation.y && rotationDirection > 0)) 
        {
                StartCoroutine(objectRotationAnimation());        
        }
        else
        {
            gameObject.transform.eulerAngles = targetRotation;
        }
    }
    IEnumerator rotateObjectAgain()
    {
        yield return new WaitForSeconds(0.2f);
        rotateObject();
    }



    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("e") &&  Time.time >= timestamp)
        {
            rotationDirection = 1;
            rotateObject();
            timestamp = Time.time + timeBetweenShots;
        }

        if (Input.GetKeyDown("q") && Time.time >= timestamp)
        {
            rotationDirection = -1;
            rotateObject();
            timestamp = Time.time + timeBetweenShots;
        }
    }


}
