using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public virtual void Shoot(GameObject shot, Vector3 shotStart, Quaternion shotStartrotation)
    {
        Instantiate(shot, shotStart, shotStartrotation);
    }
}
