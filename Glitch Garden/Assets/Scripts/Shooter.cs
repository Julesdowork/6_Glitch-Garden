using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;
    AttackerSpawner myLaneSpawner;

    void Start()
    {
        SetLaneSpawner();
    }

    void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("pew pew");
            // TODO change animation state to shooting
        }
        else
        {
            Debug.Log("sit and wait");
            // TODO change animation state to idle
        }
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }

    void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners)
        {
            bool isCloseEnough =
                (Mathf.Abs(spawner.transform.position.y - transform.position.y)
                <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    bool IsAttackerInLane()
    {
        // check for children in this lane's spawner
        return myLaneSpawner.transform.childCount > 0;
    }
}
