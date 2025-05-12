using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerButton : MonoBehaviour
{
    public int ButtonValue;
    public SceneController controller;
    public GameObject MB1;
    public GameObject MB2;
    public GameObject MB3;
    public GameObject MBV;

    public void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
    }

    public void OnMouseDown()
    {
        Debug.Log("Pushed Button " + ButtonValue);
        controller.MarkerValue = ButtonValue;
        MB1.GetComponent<Renderer>().material.color = new Color32(104, 143, 84,255);
        MB2.GetComponent<Renderer>().material.color = new Color32(104, 143, 84,255);
        MB3.GetComponent<Renderer>().material.color = new Color32(104, 143, 84,255);
        MBV.GetComponent<Renderer>().material.color = new Color32(104, 143, 84,255);
        this.GetComponent<Renderer>().material.color = new Color32(255,255,255, 255);
    }
}
