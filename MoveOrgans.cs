using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOrgans : MonoBehaviour {

    public GameObject organs;

    public Vector3 finalpos;

    private bool state = false;

    void OnSelect()
    { 
        StartCoroutine("MoveOrgan");

        Debug.Log(organs.transform.position);
        
    }

    IEnumerator MoveOrgan()
    {
        while (organs.transform.position != finalpos)
        {
            yield return new WaitForEndOfFrame();

            organs.transform.position = Vector3.MoveTowards(organs.transform.position, finalpos, Time.deltaTime);
        }
    }
}
