using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideScript : MonoBehaviour {

    public GameObject toMove;

    public GameObject toShow;

    public Vector3 finalpos;

    void OnSelect()
    {
        StartCoroutine("Move");

        toShow.SetActive(true);        
    }

    IEnumerator Move()
    {
        while(toMove.transform.position != finalpos)
        {
            yield return new WaitForEndOfFrame();

            toMove.transform.position = Vector3.MoveTowards(toMove.transform.position, finalpos, Time.deltaTime);
        }
    }
}
