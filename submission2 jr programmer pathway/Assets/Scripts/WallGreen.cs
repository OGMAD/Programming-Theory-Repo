using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

// INHERITANCE
public class WallGreen : Wall
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

    // ABSTRACTION
    void ScoreUp()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();

        // ENCAPSULATION
        Score.SetScore(Score.GetScore() + 5);
        scoreText.text = "Score: " + Score.GetScore();
    }

    // POLYMORPHISM
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreUp();
        }
    }
}
