using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;


public class ScoreManager : MonoBehaviour {

    public Text hiscoreText;
    public Done_GameController gameController;

    public float hiscoreCount;

	// Use this for initialization
	public void Start () {
		if(PlayerPrefs.GetFloat("Hiscore") != 0)
        {
            hiscoreCount = PlayerPrefs.GetFloat("Hiscore");
        }
	}
	
	// Update is called once per frame
	public void Update () {


    GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<Done_GameController>();
            if (gameController.score > hiscoreCount)
            {
                hiscoreCount = gameController.score;
                PlayerPrefs.SetFloat("Hiscore", hiscoreCount);
            }
        }
        
        hiscoreText.text = "Hiscore: " + hiscoreCount;
		
	}
}
