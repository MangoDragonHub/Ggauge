using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    /// <summary>
    /// Controls the speed the bullet is traveling;
    /// 
    /// Rashad Patterson 12/10/2020
    /// 
    /// </summary>

    private float speed = 5;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime * speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "Enemy")
        {

        }
        else
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }
}
