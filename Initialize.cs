using UnityEngine;
using System.Collections;

public class Initialize : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GameObject.Find("Objects").transform.FindChild("Box1").gameObject.SetActive(false);

        GameObject.Find("Objects").transform.FindChild("Box2").gameObject.SetActive(false);

        GameObject.Find("Objects").transform.FindChild("Box3").gameObject.SetActive(false);

        GameObject.Find("Objects").transform.FindChild("Box4").gameObject.SetActive(false);

    }
	
	
}
