using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos  = new Vector3(30, 0, 0);
    private float startDelay = 2;
    private float repateRate = 2;
    private PlayerController PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
       InvokeRepeating("SpawnObstacle", startDelay, repateRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle(){
        if(PlayerControllerScript.gameOver == false){
             Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
