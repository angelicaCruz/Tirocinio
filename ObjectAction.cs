using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour {


    private Vector3 previousPosition;


    void ModifyStart(Vector3 position)
    {
        previousPosition = position;
    }

    void ModifyUpdate(Vector3 position)
    {
        if (GestureManager.Instance.ManipulationInProgress)
        {
            Vector3 moveVector = Vector3.zero;

            moveVector = position - previousPosition;

            previousPosition = position;

            this.transform.position += moveVector;
        }
    }
}
