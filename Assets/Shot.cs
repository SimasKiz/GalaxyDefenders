using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour { 

    public float speed;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLIDED with" + other.tag);

        if (other.tag == "Enemy")
        {
           Destroy(other.gameObject);
        }
        if (other.tag == "Player")
        {
            return;

        }
    }
}
