using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideWelcom : MonoBehaviour
{
    public GameObject panel;
    [SerializeField]
    private void Start()
    {
        if (!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetInt("music", 0);
            
            PlayerPrefs.Save();
        }
    }
    public void Update()
    {

        // 1
        if (PlayerPrefs.HasKey("music2"))
        {
            if (PlayerPrefs.GetInt("Music") == 1) ;
                 panel.gameObject.SetActive(false);
        }
      
    }
    public void ToggleMusic()
    {
        
            PlayerPrefs.SetInt("music2", 1);
        
        PlayerPrefs.Save();
    }
}
