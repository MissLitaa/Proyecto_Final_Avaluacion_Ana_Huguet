using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject spawnCoin;
    public GameObject spawnBarrel;

    private Vector3 spawnPosition;
    private float randomX;
    private float randomY;
    private float randomZ;
    private float limitDome = 100;
    private float limitDome2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCoin", time:1, repeatRate:10f);
        InvokeRepeating("SpawnRandomBarrel", time:1, repeatRate:10f);
    }


    public void SpawnRandomCoin()
    {
        //Posición completamente aleatoria.
        randomX = Random.Range(-limitDome, limitDome);
        randomY = Random.Range(limitDome2, limitDome);
        randomZ = Random.Range(-limitDome, limitDome);
        spawnPosition = new Vector3(randomX, randomY, randomZ);

        Instantiate(spawnCoin, spawnPosition, spawnCoin.transform.rotation);
        
    }

    public void SpawnRandomBarrel()
    {
        //Posición completamente aleatoria.
        randomX = Random.Range(-limitDome, limitDome);
        randomY = Random.Range(limitDome2, limitDome);
        randomZ = Random.Range(-limitDome, limitDome);
        spawnPosition = new Vector3(randomX, randomY, randomZ);

        Instantiate(spawnBarrel, spawnPosition, spawnBarrel.transform.rotation);

    }
}
