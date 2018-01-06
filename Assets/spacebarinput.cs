using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VR = UnityEngine.VR;
using UnityEngine.UI;

public class spacebarinput : MonoBehaviour {


    public GameObject alarm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space)) 
        {
            alarm.SetActive(true);
        }
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            alarm.SetActive(false);
        }
		
	}
}
