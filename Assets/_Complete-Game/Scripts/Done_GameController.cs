using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Done_GameController : MonoBehaviour
{
	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	public GUIText scoreText;
	public GUIText restartText;
	public GUIText gameOverText;
    public GUIText livesText;

	private bool gameOver;
	private bool restart;
	private int score;
    public int Lives { get; private set; }

    public AudioSource powerupPickup;
	
	void Start ()
	{
        Lives = 3;
		gameOver = false;
		restart = false;
        livesText.text = "";
        restartText.text = "";
		gameOverText.text = "";
		score = 0;
		UpdateScore ();
        UpdateLives();
		StartCoroutine (SpawnWaves ());
	}
	
	void Update ()
	{
		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
			    if (hazard.tag == "Hole")
			        yield return new WaitForSeconds(1);
                Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
			
			if (gameOver)
			{
				restartText.text = "Press 'R' for Restart";
				restart = true;
				break;
			}
		}
	}
	
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}
	
	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;
	}

    public void LoseLife()
    {
        Lives = Lives - 1;
        if (Lives <= 0) GameOver();
        UpdateLives();
    }

    public void LoseAllLifes()
    {
        Lives = 0;
        if (Lives <= 0) GameOver();
        UpdateLives();
    }

    public void GainLife()
    {
        Lives = Lives + 1;
        UpdateLives();
    }

    public void UpdateLives()
    {
        livesText.text = "Lives: " + Lives;
    }

    public void PickupPowerup()
    {
        powerupPickup.Play();
    }

}