using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed;
	public float timeToFly;

	private Transform player;
	private Vector3 target;


	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player").transform;

		target = new Vector3 (player.position.x, player.position.y, player.position.z);

		
	}
	
	// Update is called once per frame
	void Update () {


		transform.position = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);


		if (timeToFly <= 0) {
			Destroy(gameObject);
		} else {
			timeToFly -= Time.deltaTime;
		}

//		void OnTriggered3D(Collider other){
//			if(other.CompareTag("Player")){
//				DestroyProjectile();
//			}
//		}

//		void DestroyProjectile(){
//			Destroy(gameObject);
//		}
	}
		
}
