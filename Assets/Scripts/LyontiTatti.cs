using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class LyontiTatti : MonoBehaviour {

	protected Joystick joystick;
//	public float moveSpeed = 8f;

	public float Ammo;
	public int magSize = 10;

	public Text ammoText; 

	public float speed;
	public GameObject Bullet;
	public GameObject Bullet_Emitter;
	public GameObject Flare;

	public AudioClip[] audioClip;


	//miten tiheää nuolia voi ampua
	public float startTimeBtwShots;
	private float timeBtwShots;

	GameObject prefab;


	// Use this for initialization
	void Start () {
		joystick = FindObjectOfType<FixedJoystick2>();
//		prefab = Resources.Load ("SwordHit") as GameObject;

		//asetellaan pyssyn ominaisuuksia
		prefab = Resources.Load ("Bullet") as GameObject;
		timeBtwShots = startTimeBtwShots;

		prefab = Resources.Load ("Flare") as GameObject;


	}

	// Update is called once per frame
		void Update () {

		Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

		if (moveVector != Vector3.zero)
		{
			transform.rotation = Quaternion.LookRotation(moveVector);
//			transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
		}
			if (moveVector != Vector3.zero && Ammo > 0 && timeBtwShots <= 0) 
		{
				ammu ();

		}
			else 
				{
					timeBtwShots -= Time.deltaTime;

				}
			
			

//		var rigidbody = GetComponent<Rigidbody> ();

//		Vector3 hitVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);
//		if (hitVector != Vector3.zero) {
//			GameObject SwordHit = Instantiate (prefab) as GameObject;
//			SwordHit.transform.position = transform.position;
//			Debug.Log ("Lyönti!");
		
		ammoText.text = "Ammo: " + Ammo;

	}

	public void ammu() {

		GameObject Temporary_Bullet_Handler;
		Temporary_Bullet_Handler = Instantiate (Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
		   //korjaa jos ammus hatullaa
		Temporary_Bullet_Handler.transform.Rotate (Vector3.left * 90);

		//työnnä ammusta
		Rigidbody Temporary_RigidBody;
		Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody> ();
		Temporary_RigidBody.AddForce (transform.forward * speed);
		//tuhoa ammus
		Destroy (Temporary_Bullet_Handler, 2.0f);
		timeBtwShots = startTimeBtwShots;

		//suuliekki
		GameObject Temporary_Flare_Handler;
		Temporary_Flare_Handler = Instantiate (Flare, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;
		Destroy (Temporary_Flare_Handler, 0.2f);

		Ammo--;

	}

	public void Reload()
	{
		Ammo = magSize;
	}
		
		
}
