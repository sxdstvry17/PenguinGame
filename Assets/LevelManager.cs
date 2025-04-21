using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public AudioClip mainMenuTheme;
    public AudioClip[] levelMusic;
    public AudioClip victoryMusic;
    public AudioSource audioSource;
    public static bool isMuted;

    private void Awake()
    {
        if (isMuted)
        {
            audioSource.mute = true;
        }
        else
        {
            audioSource.mute = false;
        }
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            audioSource.clip = mainMenuTheme;
        }
        else
        {
            audioSource.clip = levelMusic[Random.Range(0, levelMusic.Length)];
        }
    }
    private void Start()
    {
        Time.timeScale = 1;
        audioSource.Play();
    }

    public void Mute()
    {
        isMuted = true;
        audioSource.mute = true;
    }
    public void Unmute()
    {
        isMuted = false;
        audioSource.mute = false;
    }

    public void PlayVictoryMusic()
    {
        audioSource.clip = victoryMusic;
        audioSource.Play();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("6");
    }
    public void Level7()
    {
        SceneManager.LoadScene("7");
    }
    public void Level8()
    {
        SceneManager.LoadScene("8");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
