using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    protected PowerupController powerupController;

    void Start()
    {
        GameObject powerupControllerObject = GameObject.FindGameObjectWithTag("PowerUpController");
        if (powerupControllerObject != null)
        {
            powerupController = powerupControllerObject.GetComponent<PowerupController>();
        }
        if (powerupController == null)
        {
            Debug.Log("Cannot find 'PowerupController' script");
        }
    }

    public virtual void InitEffect()
    {

    }
    public virtual void Endeffect()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            powerupController.PickupPowerup();
            InitEffect();
            Destroy(gameObject);
        }
    }
}
