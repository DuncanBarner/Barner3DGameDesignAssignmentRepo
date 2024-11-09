using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


    public class GameManager : MonoBehaviour
    {
    public int score;
    
    //variable to keep track of what level we're on
    private string CurrentLevelName = string.Empty;

    #region This code makes this class a singleton
    public static GameManager instance;
    
    private void Awake()
    {
        if(instance == null)
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


    }

    //methods to load/unload scenes
    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
    if(ao == null)
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

}
