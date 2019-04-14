using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int baseLives = 4;
    [SerializeField] int damage = 1;
    int lives;
    TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        lives = baseLives - (int) PlayerPrefsController.GetDifficulty();
        Debug.Log("Difficulty setting currently is: " + PlayerPrefsController.GetDifficulty());
        livesText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
