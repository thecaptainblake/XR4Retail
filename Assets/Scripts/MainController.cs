using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MainController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] markerContent;
    void Start()
    {
        Time.timeScale = 1.0f;
        foreach (GameObject content in markerContent)
        {
            content.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MarkerFound()
    {
        foreach (GameObject content in markerContent)
        {
            content.SetActive(true);
        }

    }

    public void MarkerLost()
    {
        foreach (GameObject content in markerContent)
        {
            content.SetActive(false);
        }
    }
}
