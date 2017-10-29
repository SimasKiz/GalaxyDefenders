using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleShooting : Shooting{

  
    public override void Shoot(GameObject shot, Vector3 shotStart, Quaternion shotStartrotation)
    {
        var shotInstance = Instantiate(shot, shotStart, shotStartrotation);

        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1);
        //void ExplosionDamage(Vector3 center, float radius)
        //{
        //    Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        //    int i = 0;
        //    while (i < hitColliders.Length)
        //    {
        //        hitColliders[i].SendMessage("AddDamage");
        //        i++;
        //    }
        //}

        foreach (var collider in hitColliders)
        {
            Destroy(collider.gameObject);
        }
    }
}
