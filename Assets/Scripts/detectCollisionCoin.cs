using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollisionCoin : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider otherTrigger)
    {
        //Recolección moneda.
        if (otherTrigger.gameObject.tag == "Coin")
        {
            playerControllerScript.playerAS.PlayOneShot(playerControllerScript.coinCollect, 1f);
            Debug.Log("Hit detected");
            Destroy(GameObject.Find("Coin"));
        }

    }

}

