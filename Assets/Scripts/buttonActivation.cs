using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class buttonActivation : MonoBehaviour {

    public UnityEvent ButtonPressed;
    public GameObject controller;
    public bool active;
	// Use this for initialization
	void Start () {

        
		
	}
	
	// Update is called once per frame
	void Update () {

        if (controller.GetComponent<SteamVR_TrackedController>().padPressed == true)
        {
            ButtonPressed.Invoke();
        }

    }

    
}
