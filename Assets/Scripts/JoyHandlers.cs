using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyHandlers : MonoBehaviour {

	protected Joystick joystick;
	public float moveSpeed = 8f;


	// Use this for initialization
	void Start () {
		joystick = FindObjectOfType<FixedJoystick>();

	}
	
	// Update is called once per frame
	void Update () {

	//	var rigidbody = GetComponent<Rigidbody> ();

		Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

		if (moveVector != Vector3.zero)
		{
//			transform.rotation = Quaternion.LookRotation(moveVector);

			//liikuta ukkoo
			transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
		}   

	}

}