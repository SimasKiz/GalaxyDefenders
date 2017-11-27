using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckResume : MonoBehaviour
{
    public Transform canvas;
    public Transform canvas2;



    void Update()
    { if (canvas2.gameObject.activeInHierarchy == true)
        {
            Time.timeScale = 0;
        } else if (canvas.gameObject.activeInHierarchy == false)
        {
            Time.timeScale = 1;
        }

    }
}
