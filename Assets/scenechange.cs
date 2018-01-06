using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenechange : MonoBehaviour {

    public GameObject sight;
    public GameObject room1;
    public GameObject room2;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.F2))
        {
            sight.transform.position = room2.transform.position;
        }
        if (Input.GetKey(KeyCode.F1))
        {
            sight.transform.position = room1.transform.position;
        }

    }
}
