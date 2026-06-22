using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    #region

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }    
        else
        {
            Destroy(gameObject);
        }
    }


    //public void GameManagerCheck()
    //{
    //    Debug.Log("GameManager Check");
    //}
    #endregion

    #region Game Management

    public bool isPause;

    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        isPause = true;
    }

    public void Resume()
    {
        Time .timeScale = 1f;
        isPause = false;
    }

    #endregion

}
