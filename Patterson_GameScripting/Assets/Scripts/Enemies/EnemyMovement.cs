using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    /// <summary>
    /// Moves the enemy downwards inbetween a various amount of values.
    /// 
    /// Created by Rashad Patterson 12/10/2020
    /// </summary>

    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Random.Range(-3.5f,3.5f) * Time.deltaTime, Time.deltaTime * -speed, 0);
    }


    //Collision on Bullets

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "PBullet")
        {
            Destroy(gameObject);
        }
    }


}
