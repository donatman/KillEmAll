using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public Rigidbody rb;
	public int damage = 10;


	void OnTriggerEnter(Collider hitInfo)
	{
		FollowingEnemy enemy = hitInfo.GetComponent<FollowingEnemy> ();
		if (enemy != null) 
		{
			enemy.TakeDamage (damage);
		}

		Destroy (gameObject,0.15f);
	}

}
