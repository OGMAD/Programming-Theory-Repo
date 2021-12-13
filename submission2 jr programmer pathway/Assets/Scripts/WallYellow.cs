using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WallYellow : Wall
{
    [SerializeField] float force = 20f;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        go(force);
        destroy();
    }

    void ScoreDown()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();

        Score.SetScore(Score.GetScore() - 5);
        scoreText.text = "Score: " + Score.GetScore();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreDown();
        }
    }
}
