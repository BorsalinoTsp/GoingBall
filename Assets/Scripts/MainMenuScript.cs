using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject LevelsPanel;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] GameObject pauseButton;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LevelsMenu()
    {
        LevelsPanel.SetActive(true);
    }
    public void QuitLevelsMenu()
    {
        LevelsPanel.SetActive(false);
    }
        public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }


    // Game Over Panel
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Pause Panel
    public void PausePanel()
    {
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1.0f;
    }
    public void ReturnToMenuNoCoin()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    // LEVELS

    public void TutorialLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void Level1()
    {
        SceneManager.LoadScene(2);
    }
    public void Level2()
    {
        SceneManager.LoadScene(3);
    }
    public void Level3()
    {
        SceneManager.LoadScene(4);
    }
    public void Level4()
    {
        SceneManager.LoadScene(5);
    }
    public void Level5()
    {
        SceneManager.LoadScene(6);
    }
    public void Level6()
    {
        SceneManager.LoadScene(7);
    }
    public void Level7()
    {
        SceneManager.LoadScene(8);
    }
    public void Level8()
    {
        SceneManager.LoadScene(9);
    }
    public void BonusLevel()
    {
        SceneManager.LoadScene(10);
    }


    // LEVELS SETTINGS
    public void TutorialFinish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
        LevelsScript.tutorialLevel = 1;
        PlayerPrefs.SetInt("tutorialLevel", LevelsScript.tutorialLevel);
    }
    public void Level1Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
        LevelsScript.level1 = 1;
        PlayerPrefs.SetInt("level1", LevelsScript.level1);
    }
    public void Level2Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
        LevelsScript.level2 = 1;
        PlayerPrefs.SetInt("level2", LevelsScript.level2);
    }
    public void Level3Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
        LevelsScript.level3 = 1;
        PlayerPrefs.SetInt("level3", LevelsScript.level3);
    }
    public void Level4Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
        LevelsScript.level4 = 1;
        PlayerPrefs.SetInt("level4", LevelsScript.level4);
    }
    public void Level5Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
        LevelsScript.level5 = 1;
        PlayerPrefs.SetInt("level5", LevelsScript.level5);
    }
    public void Level6Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
        LevelsScript.level6 = 1;
        PlayerPrefs.SetInt("level6", LevelsScript.level6);
    }
    public void Level7Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
        LevelsScript.level7 = 1;
        PlayerPrefs.SetInt("level7", LevelsScript.level7);
    }
    public void Level8Finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
        LevelsScript.level8 = 1;
        PlayerPrefs.SetInt("level8", LevelsScript.level8);
    }
    public void BonusLevelFinish()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("Coin", PlayerStats.Coin);
    }

    public void ResetAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            ResetAllPlayerPrefs();
        }
    }
}
