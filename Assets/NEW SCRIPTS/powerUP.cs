using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUP : MonoBehaviour{

	public GameObject pickupEffect;

	

   void OnTriggerEnter (Collider other)
   {
		if (other.CompareTag("Player"))
		{
			Pickup(other);
		}
   }

   void Pickup(Collider Player)
   {
		Debug.Log("power up pick up!");
		// spawn a cool affect
		//Instantiate(pickupEffect, transform.position, transform.rotation);



	   // apply effect to the player
	 	 
	 /*work in progress to make a boster pick up
	 playerStats stats = player.GetComponent<ArcadeKart>();
	 stats.ArcadeKart.Stat.Acceleration *= multiplier;*/
	  //remove the power up 
	  Destroy(gameObject);

   }

}
