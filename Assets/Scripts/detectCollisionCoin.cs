using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class detectCollisionCoin : MonoBehaviour
{
    private PlayerController playerControllerScript;

    public TextMeshProUGUI scoreCount;
    private int counter;
    private int addPoint = 1;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        counter = 0;

    }

    private void Update()
    {
        scoreCount.text = $"{counter}/10";
    }

    private void OnTriggerEnter(Collider otherTrigger)
    {
        //Recolección moneda.
        if (otherTrigger.gameObject.tag == "Coin")
        {
            playerControllerScript.playerAS.PlayOneShot(playerControllerScript.coinCollect, 1f);
            Destroy(otherTrigger.gameObject);
            counter = counter + addPoint;
        }

        if (counter == 10)
        {
            scoreCount.text = $"¡Todas las monedas obtenidas!";
        }
    }
}

