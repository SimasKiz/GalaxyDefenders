using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    public Transform canvas;

    void Update()
    {
        if (canvas.gameObject.activeInHierarchy == true)
        {
            canvas.gameObject.SetActive(false);
        }
        else
        {
            canvas.gameObject.SetActive(true);
        }              

    }
}
