using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOnOff : MonoBehaviour {

    public GameObject panelOn;

    void OnSelect()
    {
        panelOn.SetActive(true);

        gameObject.SetActive(false);
    }
}
