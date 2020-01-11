using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogonSnayp : MonoBehaviour
{
	public GameObject bulletPref;
	public Transform Pistol_part;
	public float power = 1f;
	private GameObject bullet;
	float timer1;
	float timer;
	float go;
	float nou;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		timer1 += Time.deltaTime;
		if (timer1 > 4)
		{
			if (Input.GetButtonDown("Fire1"))
			{
				timer = 0;
				timer1 = 0;
			}
		}

		if (Input.GetButtonDown("Fire1"))
		{
			go = 5;
			nou = 1;
		}
		if (go == 5)
		{
			if (nou == 1)
			{
				if (timer < 2.6)
				{
					if (timer > 2.5)
					{
						if (timer < 2.55)
						{
							Shot();
							timer = 0;
							go = 0;
							nou = 0;
						}

					}
					
				}
			}
		}
		
		
		/*if (timer > 2)
	{
		Shot();
		timer = 0;
		if (Input.GetButtonDown("Fire1"))
		{
			Shot();
			timer1 = 0;
		}
		
		
	}*/
}
	private void Shot()
	{
		bullet = Instantiate(bulletPref, Pistol_part.position, Pistol_part.rotation);
		bullet.GetComponent<Rigidbody>().AddForce(gameObject.GetComponent<Transform>().up * power, ForceMode.Impulse);
		Destroy(bullet, 2f);
	}
}
