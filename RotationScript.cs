using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    public GameObject hide;

    void OnRotate( bool state)
    {
        if (state)
        {
            gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
            hide.SetActive(false);
        }
        else
            gameObject.transform.rotation = new Quaternion(0, 180, 0, 0);

    }
}
