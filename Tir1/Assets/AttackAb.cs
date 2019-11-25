using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAb : MonoBehaviour {
	public Transform bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) 
		{ 
			Transform BulletInstance = (Transform) Instantiate(bullet, GameObject.Find("Spawn").transform.position, Quaternion.identity); 
			BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 5000);
		} 
	}
}