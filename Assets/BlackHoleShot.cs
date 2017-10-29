using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleSot : Shot {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1);

        foreach (var collider in hitColliders)
        {
            if (collider.tag == "Enemy")
                Destroy(collider.gameObject);
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 1);
    }
}
