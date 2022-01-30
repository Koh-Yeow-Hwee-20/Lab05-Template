using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public ParticleSystem effects;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            effects.Play();
        }
    }
}
