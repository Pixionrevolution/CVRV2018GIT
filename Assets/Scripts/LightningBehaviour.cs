using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBehaviour : MonoBehaviour {

    bool active = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Activate()
    {
        this.gameObject.SetActive(true);
        active = true;
    }

    /// <summary>
    /// Turn off the laser sword
    /// </summary>
    public void Deactivate()
    {
      
        this.gameObject.SetActive(false);
        active = false;
    }
    public void SetActive()
    {
        if (!active)
        {
            Activate();
        }
        else if (active)
        {
            Deactivate();
        }
    }
}
