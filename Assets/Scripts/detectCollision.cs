using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    public AudioSource effectAS;
    public AudioSource missileSource;
    public AudioClip coinAC;
    public AudioClip explosionAC;
    public AudioClip missileASExplosion;

   /* public GameObject coinCollect;
    public GameObject barrelCollision;
    public GameObject playerCollision;*/


    private void OnTriggerEnter(Collider otherTrigger)
    {
        
        //Recolección moneda.
        if (otherTrigger.gameObject.tag == "Coin")
        {
            Debug.Log("Hit detected");
            effectAS.PlayOneShot(coinAC, 1f);
            Destroy(otherTrigger);
        }

        if (otherTrigger.gameObject.tag == "Barrel")
        {
            effectAS.PlayOneShot(explosionAC, 1f);
            Destroy(otherTrigger);
        }
        
        if (otherTrigger.gameObject.tag == "Barrel")
        {
            missileSource.PlayOneShot(missileASExplosion, 1f);
            Destroy(gameObject);
        }
    }

}

