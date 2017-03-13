using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeapotScript : MonoBehaviour {

    public GameObject toShow;

    void OnSelect()
    {
        toShow.SetActive(true);
    }
	
	
}
