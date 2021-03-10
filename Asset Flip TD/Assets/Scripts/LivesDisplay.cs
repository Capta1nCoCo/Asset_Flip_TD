﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] int lives = 10;
    [SerializeField] int damage = 1;
    SceneLoader sceneLoader;

    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        UpdateScore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeLife();
        Destroy(collision.gameObject);
        if (lives <= 0)
        {
            sceneLoader.LoadLoseScreen();
        }
    }

    private void TakeLife()
    {
        lives -= damage;
        UpdateScore();
    }

    private void UpdateScore()
    {
        livesText.text = lives.ToString();        
    }

    
}
