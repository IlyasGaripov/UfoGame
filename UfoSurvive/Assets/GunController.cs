using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    public Color thisColor;
    MeshRenderer thisMesh;
    public Transform prefab;
    
	// Use this for initialization
	void Start () {
        //Thi = GetComponent<Material>();
        thisMesh = GetComponent<MeshRenderer>();
        thisMesh.material.color = thisColor;
        Instantiate(prefab, this.transform);
        StartCoroutine("Shooting");
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    IEnumerator Shooting()
    {
        while (true)
        {

            prefab.Translate(-1f, 0, 0);
            yield return null;
        }
    }
}
