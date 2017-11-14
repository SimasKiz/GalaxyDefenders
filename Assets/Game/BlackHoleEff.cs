using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleEff : MonoBehaviour
{

    public float pullRadius;
    public float pullForce;
    public GameObject explosion;
    private Done_GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<Done_GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    public void FixedUpdate()
    {
        Collider[] nearByColliders = Physics.OverlapSphere(transform.position, pullRadius);

        foreach (var collider in nearByColliders)
        {
            Vector3 forceDirection = transform.position - collider.transform.position;

            if (collider.GetComponent<Rigidbody>() != null)
            {
                collider.GetComponent<Rigidbody>()
                    .AddForce(forceDirection.normalized * pullForce * Time.fixedDeltaTime);
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
            if (collider.tag == "Player")
            {
                Instantiate(explosion, transform.position, transform.rotation);
                gameController.LoseAllLifes();
                Destroy(collider.gameObject);
                return;
            }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(collider.gameObject); 
    }
}