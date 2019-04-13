using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Length of time the level progresses in seconds")]
    [SerializeField] float levelTime = 10f;
    Slider timer;

    void Start()
    {
        timer = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        timer.value = Time.timeSinceLevelLoad / levelTime;
        
        bool timerFinished = (Time.timeSinceLevelLoad > levelTime);
        if (timerFinished)
        {
            Debug.Log("Level timer expired!");
        }
    }
}
