using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    private Button button;
    
    private void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(ClickSound);
    }

    public void ClickSound(){
        SoundManager.Instance.buttonClick.Play();
    }
}
