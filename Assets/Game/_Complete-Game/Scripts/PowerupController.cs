using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PowerupController : MonoBehaviour
{
    public GameObject[] powerups;
    public Vector3 powerupSpawnValues;
    public int powerupCount;
    public float pwSpawnWait;
    public float pwStartWait;
    public float pwWaveWait;

    public AudioSource powerupPickup;


    void Start()
    {

        powerupPickup.volume = PlayerPrefs.GetFloat("SoundEffSliderVolumeLevel", powerupPickup.volume);
        StartCoroutine(PowerupSpawnWaves());
    }


    IEnumerator PowerupSpawnWaves()
    {
        yield return new WaitForSeconds(pwStartWait);
        while (true)
        {
            for (int i = 0; i < powerupCount; i++)
            {
                GameObject powerup = powerups[Random.Range(0, powerups.Length)];
                if (powerup.tag == "Hole")
                    yield return new WaitForSeconds(1);
                Vector3 pwSpawnPosition = new Vector3(Random.Range(-powerupSpawnValues.x, powerupSpawnValues.x), powerupSpawnValues.y, powerupSpawnValues.z);
                Quaternion pwSpawnRotation = Quaternion.identity;
                Instantiate(powerup, pwSpawnPosition, pwSpawnRotation);
                yield return new WaitForSeconds(pwSpawnWait);
            }
            yield return new WaitForSeconds(pwWaveWait);

        }
    }

    public void PickupPowerup()
    {
        powerupPickup.Play();
    }

}