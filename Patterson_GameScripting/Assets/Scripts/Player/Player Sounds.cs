using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    public AudioSource audioS;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            audioS.Play();
        }
    }
}
