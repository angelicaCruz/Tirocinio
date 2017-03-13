using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour {

    public GameObject toHideObj;

    public GameObject toShowObj;

    void OnSelect()
    {
        toHideObj.SetActive(false);

        toShowObj.SetActive(true);
    }
}
