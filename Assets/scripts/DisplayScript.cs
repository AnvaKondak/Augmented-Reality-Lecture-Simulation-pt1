using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DisplayScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject internetSlide, connectionSlide, IP_Slide, routingSlide, internetSlidevid, connectionSlidevid, IP_Slidevid, routingSlidevid;
    // Start is called before the first frame update
    void Start()
    {
        //3 virtual buttons 
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }

        internetSlide.SetActive(false);
        connectionSlide.SetActive(false);
        IP_Slide.SetActive(false);
        routingSlide.SetActive(false);
        internetSlidevid.SetActive(false);
        connectionSlidevid.SetActive(false);
        IP_Slidevid.SetActive(false);
        routingSlidevid.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "vb1")
        {
            Debug.Log("first button pressed");
            internetSlide.SetActive(true);
            connectionSlide.SetActive(false);
            IP_Slide.SetActive(false);
            routingSlide.SetActive(false);
            internetSlidevid.SetActive(true);
            connectionSlidevid.SetActive(false);
            IP_Slidevid.SetActive(false);
            routingSlidevid.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb2")
        {
            Debug.Log("second button pressed");
            internetSlide.SetActive(false);
            connectionSlide.SetActive(true);
            IP_Slide.SetActive(false);
            routingSlide.SetActive(false);
            internetSlidevid.SetActive(false);
            connectionSlidevid.SetActive(true);
            IP_Slidevid.SetActive(false);
            routingSlidevid.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb3")
        {
            Debug.Log("third button pressed");
            internetSlide.SetActive(false);
            connectionSlide.SetActive(false);
            IP_Slide.SetActive(true);
            routingSlide.SetActive(false);
            internetSlidevid.SetActive(false);
            connectionSlidevid.SetActive(false);
            IP_Slidevid.SetActive(true);
            routingSlidevid.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb4")
        {
            Debug.Log("Fourth button pressed");
            internetSlide.SetActive(false);
            connectionSlide.SetActive(false);
            IP_Slide.SetActive(false);
            routingSlide.SetActive(true);
            internetSlidevid.SetActive(false);
            connectionSlidevid.SetActive(false);
            IP_Slidevid.SetActive(false);
            routingSlidevid.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + " Virtual Button not supported.");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("virtual button released");
    }
}

