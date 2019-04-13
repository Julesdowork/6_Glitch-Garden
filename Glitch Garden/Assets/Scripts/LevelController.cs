using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int numAttackers = 0;
    bool levelTimerFinished = false;

    public void AttackerSpawned()
    {
        numAttackers++;
    }

    public void AttackerKilled()
    {
        numAttackers--;

        if (numAttackers <= 0 && levelTimerFinished)
        {
            Debug.Log("End level now!");
        }
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
