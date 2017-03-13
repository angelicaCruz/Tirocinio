using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesScript2 : MonoBehaviour {

    public GameObject hide1;
    public GameObject hide2;
    public GameObject hide3;

    void OnSelect()
    {
        hide1.SetActive(false);

        hide2.SetActive(false);

        hide3.SetActive(false);
    }
}
