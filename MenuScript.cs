using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

    public GameObject toHide;

    public GameObject toShow;

    void OnSelect()
    {
        toHide.SetActive(false);

        toShow.SetActive(true);
        //toShow.transform.position = new Vector3(0, -0.75f, 2.5f) ;
    }
}
