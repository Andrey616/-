using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perditio : MonoBehaviour
{
	public GameObject ObgectNew;
	public GameObject ObgectOld;
	public int Health;
	public GameObject spavnPoint;
	public GameObject objToSpavn;
	public GameObject objToSpavnOLD;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
		{
			ObgectNew.SetActive(true);
			ObgectOld.SetActive(false);
			Instantiate(objToSpavn, spavnPoint.transform.position, Quaternion.identity);
			Instantiate(objToSpavnOLD, spavnPoint.transform.position, Quaternion.identity);
		}

    }
	void OnCollisionEnter(Collision col)
	{
		if(col.collider.tag == "Destroy")
		{
			Health -= 10;
		}
	}
}
