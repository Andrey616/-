using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogom5 : MonoBehaviour
{
	public GameObject bulletPref;
	public Transform Pistol_part1;

	public float power = 1f;
	private GameObject bullet;
	private void Update()
	{
		if (Input.GetButton("Fire1"))
		{
			Shot();
		}
		if (gameObject.GetComponent<OVRGrabbable>().isGrabbed)
		{
			if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
			{
				Shot();
			}
		}
	}
	private void Shot()
	{
		bullet = Instantiate(bulletPref, Pistol_part1.position, Pistol_part1.rotation);

		bullet.GetComponent<Rigidbody>().AddForce(gameObject.GetComponent<Transform>().forward * power, ForceMode.Impulse);
		Destroy(bullet, 1f);
	}
}
