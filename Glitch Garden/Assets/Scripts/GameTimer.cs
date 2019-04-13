using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Length of time the level progresses in seconds")]
    [SerializeField] float levelTime = 10f;
    bool triggeredLevelFinished = false;
    Slider timer;

    void Start()
    {
        timer = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (triggeredLevelFinished) { return; }

        timer.value = Time.timeSinceLevelLoad / levelTime;
        
        bool timerFinished = (Time.timeSinceLevelLoad > levelTime);
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFinished = true;
        }
    }
}
