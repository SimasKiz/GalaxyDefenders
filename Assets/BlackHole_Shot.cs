using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole_Shot : Shot
{
    public float radius = 1;


    // Update is called once per frame
    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);

        foreach (var collider in hitColliders)
        {
            if (collider.tag == "Enemy")
                Destroy(collider.gameObject);
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
