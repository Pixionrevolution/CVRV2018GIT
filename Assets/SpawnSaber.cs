using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSaber : MonoBehaviour {

    public bool pop;
    public GameObject LightSaber;


	// Use this for initialization
	void Start () {
        pop = false;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (pop == true)
        {
            LightSaber.SetActive(true);
        }


    }
    public void DisableLightSaber()
    {
        
        
        
        LightSaber.SetActive(false);
        pop = false;
        
    }
}


