using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialModelPos : MonoBehaviour {

    public float x;

    public float y;

    public float z;

    // Use this for initialization
    void Start () {

        gameObject.transform.position = new Vector3(x, y, z);
		
	}
	
	
}
