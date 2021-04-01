using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{


    public Text text;
    public float fallSpeed = 5f;
    public static int score = 0;
    public static string diff = DropD1.lives;
    public void Start()
    {
        if (SaveBinary.loaded == 1)
        {
            diff = SaveBinary.lives2;
        }
        
        
            if (diff == "Easy")
                fallSpeed = 1f;
            else if (diff == "Medium")
                fallSpeed = 2f;
            else if (diff == "Difficult")
                fallSpeed = 3f;
        

    }
    public void SetWord (string word)
    {
        text.text = word;
    }
    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }
    public void RemoveWord()
    {
        Destroy(gameObject);
        score = score + 100;
        Debug.Log(score);
    }
    private void Update()
    {
        

        Debug.Log(fallSpeed);
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }
}
