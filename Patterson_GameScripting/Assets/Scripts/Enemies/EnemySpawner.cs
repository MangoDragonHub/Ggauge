using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    /// <summary>
    /// Using the spawner's Transform, it creates multiple waves of enemies
    /// on the screen.
    /// 
    /// Created by Rashad Patterson 12/10/2020
    /// </summary>

    public GameObject enemy;
    public Transform enemySpawner;
    public float spawnRate;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("SpawnEnemy", spawnRate);
        StartCoroutine(DeleteEnemy());
    }

    void SpawnEnemy()
    {
        //After X amount of seconds, spawn the enemy.
        Instantiate(enemy, enemySpawner.transform.position, enemySpawner.transform.rotation);
    }

    IEnumerator DeleteEnemy()
    {
        yield return new WaitForSeconds(5);
        Destroy(GameObject.Find("Enemy(Clone)"));
    }
}
