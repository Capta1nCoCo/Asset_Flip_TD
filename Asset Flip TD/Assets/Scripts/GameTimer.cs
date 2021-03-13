using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Round time value in SECONDS")]
    [SerializeField] float levelTime = 10;
    bool triggeredLevelFinished = false;
    LevelContoller levelContoller;

    private void Start()
    {
        levelContoller = FindObjectOfType<LevelContoller>();
    }

    void Update()
    {
        if (triggeredLevelFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            Debug.Log("level timer expired!");
            levelContoller.LevelTimerFinished();
            triggeredLevelFinished = true;
        }
    }
}
