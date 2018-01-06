using UnityEngine;
using System.Collections;



public class Print : MonoBehaviour {
	GameObject m_MonsterPrefab;
    Animator m_Anim;

    //	
    void Start () {

//		age (13);

//		iu.Print iuprint = new iu.Print (); 
//		// 결국 함수 이름이 겹치는 경우, "namespace"를 통해서 같은 이름의 다른 함수를 사용할 수 있게 해준다
//		// iu.print라는 클래스(즉 이건 namespace iu 밑에 있는 것들 사용하겠다는 얘기)
//		iuprint.hello ();
//
//		suzi.Print suziprint = new suzi.Print ();
//		suziprint.hello ();

		m_MonsterPrefab = Resources.Load ("Monster") as GameObject;
			
//		for (int i=0; i<5; ++i) {
//			for (int j=0; j<i; ++j)
//			{
				// if (~~~) -> 이게 더 보기 편하다

//				Instantiate(m_MonsterPrefab, new Vector3(i,0,j), new Quaternion());
//			}
//		}
//		for (int i=0; i<5; ++i) {
//			for (int j=0; j<i; ++j)
//			{
//				Instantiate(m_MonsterPrefab, new Vector3(j,0,i), new Quaternion());
//			}
//		}
//		for (int i=0; i<5; ++i) {
//			for (int j=1; j<5-i; ++j)
//			{
//				Instantiate(m_MonsterPrefab, new Vector3(i,0,j), new Quaternion());
//			}
//		}
//		for (int i=0; i<5; ++i) {
//			for (int j=1; j<5-i; ++j)
//			{
//				Instantiate(m_MonsterPrefab, new Vector3(j,0,i), new Quaternion());
//			}
//		}


	//	int iinput = 4;
	//	if (iinput == 0)
	//		print ("안녕");
	//	else if (iinput == 1)
	//		print ("이히힛");
	//	else if (iinput < 5)
	//		print ("공격");
	//	else
	//		print ("도망");
	}
		// 순서대로 빌드하기 때문에 조건은 항상 밑으로 내려갈 수록 더 넓어지게!
	
	// Update is called once per frame
	void Update () {

		// 좌우이동
		if (Input.GetKey ("a")) // getkey는 키를 지속적으로 눌러준다는 명령어
		{
			Vector3 vec = this.transform.position;
			vec.z += 0.1f;
			this.transform.position = vec;
            m_Anim.SetBool("walk", true);
        }
		if (Input.GetKey ("d")) 
		{
			Vector3 vec = this.transform.position;
			vec.z -= 0.1f;
			this.transform.position = vec;
            m_Anim.SetBool("walk", true);
        }

		// 전후이동
		if (Input.GetKey ("w")) 
		{
			Vector4 vec2 = this.transform.position;
			vec2.x += 0.1f;
			this.transform.position = vec2;
            m_Anim.SetBool("walk", true);
        }
		if (Input.GetKey ("s")) 
		{
			Vector3 vec2 = this.transform.position;
			vec2.x -= 0.1f;
			this.transform.position = vec2;
            m_Anim.SetBool("walk", true);
        }

		// 점프
		if (Input.GetKeyDown ("space"))  // getkeydown은 키를 딱 한 번만 누른다는 명령어
		{
			Rigidbody Rigid = this.GetComponent<Rigidbody>();
			Rigid.AddForce (this.transform.up * 250f);
		}



		}
}
