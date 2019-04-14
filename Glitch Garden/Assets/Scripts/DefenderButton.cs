using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPf;

    void Start()
    {
        LabelButtonWithCost();
    }

    void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(31, 31, 31, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPf);
    }

    void LabelButtonWithCost()
    {
        TextMeshProUGUI costText = GetComponentInChildren<TextMeshProUGUI>();
        if (!costText)
        {
            Debug.LogError(name + " has no cost text");
        }
        else
        {
            costText.text = defenderPf.GetStarCost().ToString();
        }
    }
}
