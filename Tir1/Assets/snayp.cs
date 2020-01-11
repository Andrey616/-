using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snayp : MonoBehaviour
{
	[SerializeField] private AudioSource audioSource;
	float timer;
	// Start is called before the first frame update
	void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		
		if (timer > 4)
		{
			if (Input.GetButtonDown("Fire1"))
			{
				audioSource.Play();
				timer = 0;
				
			}
		}
	}
	private void OnCollisionEnter(Collision collision)
	{
		audioSource.Play();
	}
}
