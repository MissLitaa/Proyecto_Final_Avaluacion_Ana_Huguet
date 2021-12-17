using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectColissionGameOver : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private deathSounds explodingChopper;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        explodingChopper = GameObject.Find("DeathSound").GetComponent<deathSounds>();
    }
    private void OnTriggerEnter(Collider otherTrigger)
    {
        //GAME OVER (Death).
        if (otherTrigger.gameObject.tag == "Barrel")
        {
           playerControllerScript.playerAS.PlayOneShot(playerControllerScript.explosionBarrel, 1f);
           Destroy(gameObject); 
           Destroy(otherTrigger);
           explodingChopper.deathExplosionAS.PlayOneShot(explodingChopper.explosion, 0.2f);
        }

    }
}


