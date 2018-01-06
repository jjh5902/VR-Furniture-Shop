using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFieldScript : MonoBehaviour {

    public GameObject input;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            input.SetActive(true);
        }
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            input.SetActive(false);
        }
	}
}
