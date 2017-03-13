using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    private bool state = false;

	// Use this for initialization
	void Start () {

        GameObject.Find("Objects").transform.FindChild("Box1").gameObject.SetActive(state);

        GameObject.Find("Objects").transform.FindChild("Box2").gameObject.SetActive(state);

        GameObject.Find("Objects").transform.FindChild("Box3").gameObject.SetActive(state);

        GameObject.Find("Objects").transform.FindChild("Box4").gameObject.SetActive(state);   

    }
	
	// Update is called once per frame
	void OnSelect () {

        state = !state;

        GameObject.Find("Objects").transform.FindChild("Box1").gameObject.SetActive(state);

        GameObject.Find("Objects").transform.FindChild("Box2").gameObject.SetActive(state);

        GameObject.Find("Objects").transform.FindChild("Box3").gameObject.SetActive(state);

        GameObject.Find("Objects").transform.FindChild("Box4").gameObject.SetActive(state);

    }
}
