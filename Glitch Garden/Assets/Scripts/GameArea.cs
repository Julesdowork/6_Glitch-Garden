using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameArea : MonoBehaviour
{
    [SerializeField] GameObject defender;

    void OnMouseDown()
    {
        SpawnDefender();
    }

    void SpawnDefender()
    {
        GameObject newDefender = Instantiate(defender, transform.position, Quaternion.identity);
    }
}
