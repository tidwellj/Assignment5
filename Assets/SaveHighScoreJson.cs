﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class SaveHighScoreJson : MonoBehaviour
{

    // static public bool expo2;
    //static public int altScore = 0;
    static public int score = 300;
    static public int score1 = 200;
    static public int score2 = 100;
    public static string textscore4;
    public static string textscore5;
    public static string textscore6;

    [System.Serializable]
    public class MyClass
    {



        public int score;
        public int score1;
        public int score2;
        public int score3;
       
        // public int music;


    }
    public SaveHighScoreJson.MyClass myObject = new SaveHighScoreJson.MyClass();
   

    public void Start()
    {
      
        myObject.score = WordDisplay.score;
        


        if (myObject.score > score)
        {
            score = myObject.score;
        }
        else if (myObject.score < score && myObject.score > score1)
        {
            score1 = myObject.score;
        }
        else if (myObject.score < score1 && myObject.score > score2)
        {
            score2 = myObject.score;
        }
        myObject.score1 = score;
         myObject.score2 = score1;
         myObject.score3 = score2;
       


        /*
        if (nam == 1)
        {
            myObject.textscore1 = NameText.userIDs + " " + score.ToString();
        }
        else
        {
            myObject.textscore1 = score.ToString();
        }

        if (nam == 1)
        {
            myObject.textscore2 = NameText.userIDs + " " + score1.ToString();
        }
        else
        {
            myObject.textscore2 = score1.ToString();
        }

        if (nam == 1)
        {
            myObject.textscore3 = NameText.userIDs + " " + score2.ToString();
        }
        else
        {
            myObject.textscore3 = score2.ToString();
        }
        myObject.textscore1 = myObject.textscore1;
        */
       
        Debug.Log("quack" + myObject.score);
       

        var json = JsonUtility.ToJson(myObject);

      
        PlayerPrefs.SetString("Save", json);

        PlayerPrefs.Save();
      
    }

    public void LoadIt()
    {

        string json = PlayerPrefs.GetString("Save");

        myObject = JsonUtility.FromJson<SaveHighScoreJson.MyClass>(json);


        

      
         score = myObject.score1;
        score1 = myObject.score2;
        score2 = myObject.score3;
       
       
        
        
        PlayerPrefs.Save();


       

       // expo2 = true;
    }


}
