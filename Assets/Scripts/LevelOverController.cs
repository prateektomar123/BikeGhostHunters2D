using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour
{
    public UnityEvent onLevelComplete;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            onLevelComplete.Invoke();
            Time.timeScale = 0f;
            Debug.Log("Level Completed");
        }
    }

    public void NextLevel()
    {
        LevelManager.Instance.SetLevelIndex(PlayerPrefs.GetInt("LevelIndex") + 1);
        
    
    }
}
