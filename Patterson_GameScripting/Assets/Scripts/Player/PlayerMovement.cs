using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// This controls the player's movement on the X and Y Axises
    /// 
    /// Rashad Patterson 12/10/20
    /// </summary>

    [Header("X and Y Speed")]
    public float x = 5;
    public float y = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        //Uses the 'Vertical' and 'Horizontal' axises to control the player's movement.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0)
        {
            transform.Translate(Time.deltaTime * x, 0, 0);
        }
        else if (horizontal < 0)
        {
            transform.Translate(Time.deltaTime * -x, 0, 0);
        }

        if (vertical > 0)
        {
            transform.Translate(0, Time.deltaTime * y, 0);
        }
        else if (vertical < 0)
        {
            transform.Translate(0, Time.deltaTime * -y, 0);
        }

    }
}
