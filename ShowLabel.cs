using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLabel : MonoBehaviour {

    public GameObject show;

    void OnShow(bool state)
    {
        show.SetActive(state);
    }
}
