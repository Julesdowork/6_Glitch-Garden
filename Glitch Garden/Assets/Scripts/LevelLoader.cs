using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float loadTime = 5f;
    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadGame());
        }
    }

    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(loadTime);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start");
    }

    public void LoadOptionsScreen()
    {
        SceneManager.LoadScene("Options");
    }

    public void LoadLoseScreen()
    {
        SceneManager.LoadScene("Lose");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game!");
        Application.Quit();
    }
}
