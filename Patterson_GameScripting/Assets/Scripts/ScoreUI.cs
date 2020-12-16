using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    //Adds score +1 every time the player is alive!
    private void Start()
    {
        StartCoroutine(AddScore());
    }

    IEnumerator AddScore()
    {
        int score = 0;
        while (true)
        {
            
            scoreText.text = "Score: " + score;
            yield return new WaitForSeconds(2);
            score += 1;
        }
    }


}
