using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI livesText;
    int lives = 10;
    SceneLoader sceneLoader;

    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
        UpdateScore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        lives--;
        UpdateScore();
        if (lives <= 0)
        {
            sceneLoader.LoadLoseScreen();
        }
    }

    private void UpdateScore()
    {
        livesText.text = lives.ToString();        
    }

    
}
