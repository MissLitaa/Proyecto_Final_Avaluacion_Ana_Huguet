using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileBehaviour : MonoBehaviour
{
    private float missileSpeed = 50f;
    private PlayerController playerControllerScript;
    private Vector3 limitMissile = new Vector3(200, 200, 200);

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        //Movimiento hacia adelante.
        transform.Translate(Vector3.forward * Time.deltaTime * missileSpeed);
        
        if (transform.position == limitMissile)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider otherTrigger)
    {

        //Destrucción barril.
        if (otherTrigger.gameObject.tag == "Barrel")
        {
            playerControllerScript.playerAS.PlayOneShot(playerControllerScript.explosionBarrel, 1f);
            Destroy(otherTrigger);
        }

    }
}
