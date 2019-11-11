using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInfo : MonoBehaviour {

    // Use this for initialization

    public string Message;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnMouseDown()
    {

      GameObject.FindGameObjectWithTag("Finish").transform.Find("Infopanel").gameObject.SetActive(true);
      GameObject.FindGameObjectWithTag("Finish").transform.Find("Infopanel").Find("Text").GetComponent<Text>().text = Message;

    }
}
