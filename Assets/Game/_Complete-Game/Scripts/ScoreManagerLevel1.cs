using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;


public class ScoreManagerLevel1 : MonoBehaviour
{

    public Done_GameController gameController;
    public Transform canvas;

    // Use this for initialization
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<Done_GameController>();
            if (gameController.score >= 100)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
