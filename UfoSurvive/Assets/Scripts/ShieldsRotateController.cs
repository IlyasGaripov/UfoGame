using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldsRotateController : MonoBehaviour
{
    public int rotationDirection; // -1 for clockwise
                                  //  1 for anti-clockwise


    private bool rotate;
    private bool alreadyRotate = false;

    public int rotationStep = 4;
    int delta = 10;

    private bool buttonClicked = false;
 
    // All the objects with which collision will be checked
    public GameObject[] objectsArray;

    private Vector3 currentRotation, targetRotation;

    public Button bttn;

    private int direction;
    private Quaternion qTo = Quaternion.identity;

    public void OnPressLeft()
    {
        rotationDirection = 1;
        rotate = true;
        if (!alreadyRotate)
            StartCoroutine(RotateAround(currentRotation, 90*rotationDirection, 0.1f));
    }
    public void OnPressRight()
    {
        rotationDirection = -1;
        rotate = true;
        if (!alreadyRotate)
            StartCoroutine(RotateAround(currentRotation, 90 * rotationDirection, 0.1f));
    }

    public void OnReleaseLeft()
    {
        rotate = false;
    }
    public void OnReleaseRight()
    {
        rotate = false;
    }

    void Start()
    {
        currentRotation = new Vector3(0, -1, 0);
    }

    IEnumerator RotateAround(Vector3 axis, float angle, float duration)
    {
        float elapsed = 0.0f;
        float rotated = 0.0f;
        while (elapsed < duration)
        {
            alreadyRotate = true;
            float step = angle / duration * Time.deltaTime;
            transform.RotateAround(transform.position, axis, step);
            elapsed += Time.deltaTime;
            rotated += step;
            yield return null;
        }
        alreadyRotate = false;
        transform.RotateAround(transform.position, axis, angle - rotated);
    }
    // Update is called once per frame
    void Update()
    {
        if(rotate)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, qTo, 2 * Time.deltaTime);
        }
    }

}
