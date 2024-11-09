using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using StarterAssets;


public class GameManager : Singleton<GameManager>
{
    public int score;

    public GameObject pauseMenu;

    //variable to keep track of what level we're on
    private string CurrentLevelName = string.Empty;

  /*  #region This code makes this class a singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //Make sure this game manager persists across scenes
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
            Debug.Log("Trying to Instantiate" +
                "a second instance of singleton game manager");
        }
        #endregion


    }*/

    //methods to load/unload scenes
    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null)
        {
            Debug.LogError("[GameManager.cs] unable to load level " + levelName);
        }

        CurrentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager.cs] unable to unload level " + levelName);
        }

    }
    
    //pause/unpause
    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager.cs] unable to unload level " + CurrentLevelName);
        }
    }



}


