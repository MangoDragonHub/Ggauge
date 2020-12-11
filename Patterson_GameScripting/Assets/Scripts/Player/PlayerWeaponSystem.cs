using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponSystem : MonoBehaviour
{
    /// <summary>
    /// The Player Weapon System will handle all Weapon types when
    /// the player switches weapons and how do they shoot.
    /// 
    /// Created by Rashad Patterson 12/10/2020
    /// 
    /// -To DO-
    /// X Press a button to spawn object
    /// XChange the rate of how that object spawns
    /// X After x amount of seconds, delete those spawned objects.
    /// _ Do not make the player's bullts Collide with the player.
    /// 
    /// 
    /// 
    /// </summary>
    /// 

    public GameObject playerBullet;
    public Transform spawnLocation;
    public int fireRate;
    public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FiringObject();
        StartCoroutine(DeleteBullets());
    }

    void FiringObject()
    {
        //If a button is press, spawn the object and send it in the forward direction.

        if (Input.GetKey(KeyCode.Return))
        {
            Invoke("GunFiringRate",spawnTime);
        }
    }

    void GunFiringRate()
    {
        Instantiate(playerBullet, spawnLocation.position, spawnLocation.rotation);
        Physics2D.IgnoreCollision(playerBullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    IEnumerator DeleteBullets()
    {
        //After spawning if it doesn't hit anything after x amount of seconds. 
        //The bullet(s) are deleted.
        yield return new WaitForSeconds(5f);
        Destroy(GameObject.Find("Bullet(Clone)"));

        
    }
}
