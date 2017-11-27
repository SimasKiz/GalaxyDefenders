using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinning : MonoBehaviour {
    public Transform canvas;
    public Done_GameController gameController;



    void Update()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<Done_GameController>();
            if (gameController.score >= 100)
            {
                Winning();
            }
        }

    }
    public void Winning()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}