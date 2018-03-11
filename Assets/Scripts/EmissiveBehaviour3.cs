using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
namespace DigitalRuby.LaserSword
{
    public class EmissiveBehaviour3 : MonoBehaviour
    {

        bool active = false;
        public GameObject lame;


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (active && lame.GetComponent<LaserSwordScript>().pubState == 1 )
            {
                Renderer renderer = GetComponent<Renderer>();
                Material mat = renderer.material;
                float floor = 0.1f;
                float ceiling = 1.0f;
                float emission = floor + Mathf.PingPong(Time.time, ceiling - floor);

                Color baseColor = Color.yellow; //Replace this with whatever you want for your base color at emission level '1'

                Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);

                mat.SetColor("_EmissionColor", finalColor);
            }

            else if (!active && lame.GetComponent<LaserSwordScript>().pubState == 2 )
            {
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
            }

            
        }
        public void Activate()
        {
            active = true;
        }

        /// <summary>
        /// Turn off the laser sword
        /// </summary>
        public void Deactivate()
        {


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
}

