using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

	public float speed;
	public float HitRadius = 1;
	public float SeeRadius = 7;

	private Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, target.position) > HitRadius && Vector3.Distance (transform.position, target.position) < SeeRadius ) 
		{
			transform.position = Vector3.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
			//facing the player
			Vector3 direction = (target.position - transform.position).normalized;
			Quaternion lookRotation = Quaternion.LookRotation (new Vector3 (direction.x, 0, direction.z));
			transform.rotation = Quaternion.Slerp (transform.rotation, lookRotation, Time.deltaTime * 5f);

		}

		
	}
}
