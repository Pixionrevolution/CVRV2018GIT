using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionsabre : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

    void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
    }
}
