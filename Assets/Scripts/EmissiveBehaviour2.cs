using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
namespace DigitalRuby.LaserSword
{
    public class EmissiveBehaviour2 : MonoBehaviour
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
                GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.white);
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

