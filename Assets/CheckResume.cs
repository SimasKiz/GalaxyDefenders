using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckResume : MonoBehaviour
{
    public Transform canvas;



    void Update()
    {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                Time.timeScale = 1;
            }

    }
}
