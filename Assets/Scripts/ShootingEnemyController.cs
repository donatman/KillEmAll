using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootingEnemyController : MonoBehaviour {

	public float speed = 2;
	public float stoppingDistance = 5;
	public float retreatDistance = 3;
	public float seeRadius = 9;

	//shooting
	private float timeBtwShots;
	public float startTimeBtwShots;

	public GameObject projectile;

	private Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;

		timeBtwShots = startTimeBtwShots;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (transform.position, target.position) > stoppingDistance && Vector3.Distance (transform.position, target.position) < seeRadius) {
			
			transform.position = Vector3.MoveTowards (transform.position, target.position, speed * Time.deltaTime);

			//facing the player
			Vector3 direction = (target.position - transform.position).normalized;
			Quaternion lookRotation = Quaternion.LookRotation (new Vector3 (direction.x, 0, direction.z));
			transform.rotation = Quaternion.Slerp (transform.rotation, lookRotation, Time.deltaTime * 5f);

		} else if (Vector3.Distance (transform.position, target.position) < stoppingDistance && Vector3.Distance (transform.position, target.position) > retreatDistance) {

			transform.position = this.transform.position;

			//facing the player
			Vector3 direction = (target.position - transform.position).normalized;
			Quaternion lookRotation = Quaternion.LookRotation (new Vector3 (direction.x, 0, direction.z));
			transform.rotation = Quaternion.Slerp (transform.rotation, lookRotation, Time.deltaTime * 5f);

		} else if (Vector3.Distance (transform.position, target.position) < retreatDistance) {

			transform.position = Vector3.MoveTowards (transform.position, target.position, -speed * Time.deltaTime);

			//facing the player
			Vector3 direction = (target.position - transform.position).normalized;
			Quaternion lookRotation = Quaternion.LookRotation (new Vector3 (direction.x, 0, direction.z));
			transform.rotation = Quaternion.Slerp (transform.rotation, lookRotation, Time.deltaTime * 5f);

		}




		if (timeBtwShots <= 0 && Vector3.Distance (transform.position, target.position) < seeRadius)  {

			Instantiate (projectile, transform.position, Quaternion.identity);
			timeBtwShots = startTimeBtwShots;

		} else {

			timeBtwShots -= Time.deltaTime;


		}

		
	}
}
