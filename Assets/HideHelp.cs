using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideHelp : MonoBehaviour
{
    public GameObject panel;

    public void Start()
    {
        panel.SetActive(false);
    }
    public void HidePanel()
    {
        panel.SetActive(false);  
    }
    public void ShowPanel()
    {
        panel.SetActive(true);
    }
}
