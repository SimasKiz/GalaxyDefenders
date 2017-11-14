using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadPowerUp : PowerUp {
    public override void InitEffect()
    {
        Done_PlayerController playerController;
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            playerController = playerObject.GetComponent<Done_PlayerController>();
            playerController.shooting = new SpreadShooting();
        }
    }
}
