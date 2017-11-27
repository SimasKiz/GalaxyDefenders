using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : PowerUp {

    public override void InitEffect()
    {
        Done_GameController gameController;
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<Done_GameController>();
            gameController.GainLife();
        }
    }

}


