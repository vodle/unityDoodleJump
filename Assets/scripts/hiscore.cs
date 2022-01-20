using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hiscore : MonoBehaviour
{
    public float Score;
    public Text scoreText;
    void Start()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            scoreText.text = PlayerPrefs.GetFloat("Score").ToString();
            
        }    
    }
    
    void Update()
    {
        
    }
}
