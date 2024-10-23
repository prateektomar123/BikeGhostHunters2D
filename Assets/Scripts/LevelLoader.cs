using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LevelLoader : MonoBehaviour
{
   public Button button;
   public int LevelIndex;

   private void Awake() {
     button = GetComponent<Button>();
     button.onClick.AddListener(onClick);
     PlayerPrefs.SetInt("LevelProgress_1",1);
   }
private void Start() {
  if(PlayerPrefs.GetInt("LevelProgress_" + LevelIndex) == 1){
    button.interactable = true;
  }
  else{
    button.interactable = false;
  }
}
   private void onClick(){
    
     LevelManager.Instance.SetLevelIndex(LevelIndex);
     SceneManager.LoadScene(1);
     
   }

    


}
