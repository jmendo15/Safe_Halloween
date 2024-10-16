using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu, options, extras, credits, difficulty, loading;
    public string gameSceneName;

    public void openOptions()
    {
        menu.SetActive(false);
        options.SetActive(true);
    }
    public void openExtras()
    {
        menu.SetActive(false);
        extras.SetActive(true);
    }
    public void openCredits()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }
    public void goBack()
    {
        options.SetActive(false);
        extras.SetActive(false);
        credits.SetActive(false);
        difficulty.SetActive(false);
        menu.SetActive(true);
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void playGame()
    {
        menu.SetActive(false);
        difficulty.SetActive(true);
    }
    public void veryHard()
    {
        PlayerPrefs.SetInt("difficulty", 0);
        PlayerPrefs.Save();
        difficulty.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }
    public void Hard()
    {
        PlayerPrefs.SetInt("difficulty", 1);
        PlayerPrefs.Save();
        difficulty.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }
    public void Medium()
    {
        PlayerPrefs.SetInt("difficulty", 2);
        PlayerPrefs.Save();
        difficulty.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }
    public void Easy()
    {
        PlayerPrefs.SetInt("difficulty", 3);
        PlayerPrefs.Save();
        difficulty.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }
}