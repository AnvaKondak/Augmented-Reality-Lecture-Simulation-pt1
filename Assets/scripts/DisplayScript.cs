using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DisplayScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject A1, A2, A3, A4, A1vid, A2vid, A3vid, A4vid;
    // Start is called before the first frame update
    void Start()
    {
        //3 virtual buttons 
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }

        A1.SetActive(false);
        A2.SetActive(false);
        A3.SetActive(false);
        A4.SetActive(false);
        A1vid.SetActive(false);
        A2vid.SetActive(false);
        A3vid.SetActive(false);
        A4vid.SetActive(false);

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
            A1.SetActive(true);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A1vid.SetActive(true);
            A2vid.SetActive(false);
            A3vid.SetActive(false);
            A4vid.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb2")
        {
            Debug.Log("second button pressed");
            A1.SetActive(false);
            A2.SetActive(true);
            A3.SetActive(false);
            A4.SetActive(false);
            A1vid.SetActive(false);
            A2vid.SetActive(true);
            A3vid.SetActive(false);
            A4vid.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb3")
        {
            Debug.Log("third button pressed");
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(true);
            A4.SetActive(false);
            A1vid.SetActive(false);
            A2vid.SetActive(false);
            A3vid.SetActive(true);
            A4vid.SetActive(false);
        }
        else if (vb.VirtualButtonName == "vb4")
        {
            Debug.Log("Fourth button pressed");
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(true);
            A1vid.SetActive(false);
            A2vid.SetActive(false);
            A3vid.SetActive(false);
            A4vid.SetActive(true);
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

