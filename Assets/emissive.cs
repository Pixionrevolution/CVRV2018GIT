using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emissive : MonoBehaviour {

    //private float IntensiteMax;
    //private float IntensiteMin;
    //private Material matLampe;
    //public Color color;
    [Range(1.0f,2.5f)]
    public float intensity = 2.5f;
    public float amplitude = 0.65f;


	// Use this for initialization
	void Start () {


        


    }
	
	// Update is called once per frame
	void Update () {

        Renderer renderer = GetComponent<Renderer>();
        Material mat = renderer.material;

        //float emission = Mathf.PingPong(Time.time , 1.0f);
        Color baseColor = Color.white; //Replace this with whatever you want for your base color at emission level '1'

        float glow = (2 + Mathf.Cos(Time.time * intensity)) * amplitude;

      
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(glow);
        

        mat.SetColor("_EmissionColor", finalColor * glow);

    }
}
