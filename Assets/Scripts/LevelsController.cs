using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelsController : MonoBehaviour
{
    public GameObject[] Levels;
    public UnityEvent OnLastLevel;
    private int CurrentLevelIndex;

    private void Start() {
        CurrentLevelIndex = PlayerPrefs.GetInt("LevelIndex", 1);
        foreach (var item in Levels)
        {
            item.SetActive(false);
        }
        Levels[CurrentLevelIndex - 1].SetActive(true);

        if(Levels[Levels.Length - 1].activeSelf){
            OnLastLevel.Invoke();
        }
    }

    public void NextLevel(){

        PlayerPrefs.SetInt("LevelProgress_" + (CurrentLevelIndex + 1) ,1);
        PlayerPrefs.SetInt("LevelIndex" , CurrentLevelIndex + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
