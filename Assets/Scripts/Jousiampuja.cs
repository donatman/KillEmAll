/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jousiampuja : MonoBehaviour {

	protected Joystick joystick;
	//	public float moveSpeed = 8f;


	public float speed;
	public GameObject Nuoli;
	public GameObject Bullet_Emitter;

	//miten tiheää nuolia voi ampua
	public float startTimeBtwShots;
	private float timeBtwShots;

	GameObject prefab;

	// Use this for initialization
	void Start () {
//		joystick = FindObjectOfType<FixedJoystick2>();
		prefab = Resources.Load ("Nuoli") as GameObject;
		timeBtwShots = startTimeBtwShots;


	}

	// Update is called once per frame
//	void Update () {

		//		var rigidbody = GetComponent<Rigidbody> ();

//		Vector3 hitVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);
//		if (hitVector != Vector3.zero && timeBtwShots <= 0) {

//			GameObject Temporary_Bullet_Handler;
//			Temporary_Bullet_Handler = Instantiate (Nuoli, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
			//korjaa jos nuoli hatullaa
			//		Temporary_Bullet_Handler.transform.Rotate (Vector3.left * 90);

//			Rigidbody Temporary_RigidBody;
//			Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody> ();

			//työnnä nuolta
//			Temporary_RigidBody.AddForce (transform.forward * speed);

//			Destroy (Temporary_Bullet_Handler, 4.0f);

//			timeBtwShots = startTimeBtwShots;


//			Debug.Log ("Ampu!");
//		} else {
//			timeBtwShots -= Time.deltaTime;
//		}

//	}


	public void ammu() {

		GameObject Temporary_Bullet_Handler;
		Temporary_Bullet_Handler = Instantiate (Nuoli, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
		//korjaa jos nuoli hatullaa
		Temporary_Bullet_Handler.transform.Rotate (Vector3.left * 90);
		Rigidbody Temporary_RigidBody;
		Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody> ();

		//työnnä nuolta
		Temporary_RigidBody.AddForce (transform.forward * speed);

		Destroy (Temporary_Bullet_Handler, 4.0f);

		timeBtwShots = startTimeBtwShots;


		Debug.Log ("Ampu!");


	}



}*/
