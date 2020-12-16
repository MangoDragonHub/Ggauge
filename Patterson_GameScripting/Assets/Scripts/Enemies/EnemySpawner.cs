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
    public float waitTime;
    

    // Update is called once per frame
    void Update()
    {
        
        StartCoroutine(DeleteEnemy());
        StartCoroutine(InvokeSpawning());
    }

    IEnumerator DeleteEnemy()
    {
        yield return new WaitForSeconds(10);
        Destroy(GameObject.Find("Enemy(Clone)"));
    }

    IEnumerator InvokeSpawning()
    {   //After X amount of seconds, spawn the enemy.
        while (true)
        {
            Instantiate(enemy, enemySpawner.transform.position, enemySpawner.transform.rotation);
            yield return new WaitForSeconds(waitTime);
        }

    }
}
