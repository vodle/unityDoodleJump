using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float horizontalAcsel;
    public Rigidbody2D rigitPlayer;
    public float force = 10f;
    public static player instance;
    public float previosScore = 0, Score = 0;
    public Text scoreText;
    public int LoadScen;
    void Start()
    {
        instance = this;
    }

   
    void FixedUpdate()
    {
        horizontalAcsel = Input.acceleration.x;

        if (horizontalAcsel < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (horizontalAcsel > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        rigitPlayer.velocity = new Vector2(horizontalAcsel * force, rigitPlayer.velocity.y);
        if (Score > previosScore)
        {
            previosScore = Score;
            saveScore(Score);
            
        }
        scoreText.text = previosScore.ToString();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "DeadZone")
        {
            SceneManager.LoadScene(LoadScen);
        }
    }

    public void saveScore(float Score)
    {
        PlayerPrefs.SetFloat("Score", Score);
        PlayerPrefs.Save();
    }
    
}
