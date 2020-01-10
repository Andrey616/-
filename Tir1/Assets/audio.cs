using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
	[SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
	private void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			audioSource.Play();
		}
		if (gameObject.GetComponent<OVRGrabbable>().isGrabbed)
		{
			if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
			{
				audioSource.Play();
			}
		}
	}
	private void OnCollisionEnter(Collision collision)
	{
		audioSource.Play();
	}
}
