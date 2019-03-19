using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsMarker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] markerContent;
    void Start()
    {
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
        Debug.Log("arturo se la come");

    }

    public void MarkerLost()
    {
        foreach (GameObject content in markerContent)
        {
            content.SetActive(false);
        }
    }

}
