using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class mishen : MonoBehaviour
{

	float timer;
	bool side;
    // Start is called before the first frame update
    void Start()
    {
		side = true;
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
if (timer > 2)
			if(side == true)
			{
				side = false;
				timer = 0;
			}
			else
			{
				side = true;
				timer = 0;
			}

		Move(side);
	}

	public void Move(bool side)
	{
		if(side == true)
			gameObject.transform.position += new Vector3(Time.deltaTime, 0, 0);
		else
			gameObject.transform.position += new Vector3(-Time.deltaTime, 0, 0);
	}
}
