using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadShooting : Shooting {

    public override void Shoot(GameObject shot, Vector3 shotStart, Quaternion shotStartrotation)
    {
        Instantiate(shot, shotStart + new Vector3(0.3f, 0, 0), Quaternion.Euler(shotStartrotation.x, shotStartrotation.y + 12, shotStartrotation.z));
        Instantiate(shot, shotStart, shotStartrotation);
        Instantiate(shot, shotStart - new Vector3(0.3f, 0, 0), Quaternion.Euler(shotStartrotation.x, shotStartrotation.y - 12, shotStartrotation.z));
    }
}
