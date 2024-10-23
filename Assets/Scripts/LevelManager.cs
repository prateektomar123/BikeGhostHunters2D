using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    public static LevelManager Instance { get { return instance; } }
    public string level1;
    private void Awake() {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    private void Start() {
        
    }
    
    
    public void SetLevelStatus(int levelIndex){
        PlayerPrefs.SetInt("LevelProgress_" + levelIndex ,1);
        
    }
    public void SetLevelIndex(int levelIndex){
        PlayerPrefs.SetInt("LevelIndex" ,levelIndex);
    }
    
}
