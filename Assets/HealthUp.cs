using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : PowerUp {
    public override void InitEffect()
    {
        gameController.GainLife();
    }
}
