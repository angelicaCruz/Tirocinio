using UnityEngine;
using System.Collections;
using HoloToolkit.Unity;
using System;

public class GestureAction : MonoBehaviour {

    [Tooltip("Rotation max speed controls amount of rotation.")]
    public float RotationSensitivity = 10.0f;

    private float rotationFactor;

    Vector3 previousPosition;

   /* void Update()
    {
        PerformModify();
    }


    private void PerformModify()
    {
        if (GestureManager.Instance.ManipulationInProgress && GestureManager.Instance.FocusedObject!=null)
        {

            moveVector += HandsManager.Instance.ManipulationHandPosition;
        }
    }*/
    
    void ModifyStart(Vector3 position)
    {
        previousPosition = position;
    }

    void ModifyStartUpdate(Vector3 position)
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
