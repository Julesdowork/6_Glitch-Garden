using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefsController.SetMasterVolume(0.4f);
        Debug.Log("Master volume set to: " + PlayerPrefsController.GetMasterVolume());
    }
}
