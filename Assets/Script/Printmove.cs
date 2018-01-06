using UnityEngine;
using System.Collections;

public class Printmove : MonoBehaviour {
	GameObject m_MonsterPrefab;
	
	void Start () {
		m_MonsterPrefab = Resources.Load ("Monster") as GameObject;			
	}
			
	void Update () {

        CameraMovement();
		

		}

    public void CameraMovement ()
    {
        if (Input.GetKey("a"))
        {
            Vector3 vec = this.transform.position;
            vec.z += 1f;
            this.transform.position = vec;
        }
        if (Input.GetKey("d"))
        {
            Vector3 vec = this.transform.position;
            vec.z -= 1f;
            this.transform.position = vec;
        }


        if (Input.GetKey("w"))
        {
            Vector4 vec2 = this.transform.position;
            vec2.x += 1f;
            this.transform.position = vec2;
        }
        if (Input.GetKey("s"))
        {
            Vector3 vec2 = this.transform.position;
            vec2.x -= 1f;
            this.transform.position = vec2;
        }


        if (Input.GetKeyDown("space"))
        {
            Rigidbody Rigid = this.GetComponent<Rigidbody>();
            Rigid.AddForce(this.transform.up * 250f);
        }

        /*
        if (Input.GetKey("q"))
        {
            Vector3 vec3 = RotationDriveMode.XYAndZ();
            vec3.x += 1f;
            this.transform.roatation = vec3;
        }
        if (Input.GetKey("e"))
        {
            Vector3 vec3 = RotationDriveMode.XYAndZ();
            vec3.x -= 1f;
            this.transform.roatation = vec3;
        }
        */

    }
}
