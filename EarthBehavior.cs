using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthBehavior : MonoBehaviour {

    public GameObject showObj;

    void OnSelect()
    {
        showObj.SetActive(true);
    } 
}
