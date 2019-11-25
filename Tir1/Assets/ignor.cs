using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignor : MonoBehaviour
{
	public List<Collider> cols = new List<Collider>();
    // Start is called before the first frame update
    void Start()
    {
        foreach(Collider collision in cols)
		{
			Physics.IgnoreCollision(collision, GetComponent<Collider>());
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
