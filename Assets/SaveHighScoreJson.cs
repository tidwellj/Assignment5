using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class SaveHighScoreJson : MonoBehaviour
{
   
    static public int score = 3;
    static public int score1 = 2;
    static public int score2 = 1;
    public static string textscore4;
    public static string textscore5;
    public static string textscore6;
    public static int nam = 0;
    public static int nam2 = 0;
    public static bool loaded;
    [System.Serializable]
    public class MyClass
    {



        public int score;
        public int score1;
        public int score2;
        public int score3;
        public string textscore1;
        public string textscore2;
        public string textscore3;



    }
    public SaveHighScoreJson.MyClass myObject = new SaveHighScoreJson.MyClass();


    public void Bingo()
    {

        myObject.score = WordDisplay.score;


        if (myObject.score > score)
        {
            textscore4 = "1      " + NameText.userIDs + "      " + myObject.score;
            score = myObject.score;
        }
        else if (myObject.score < score && myObject.score > score1)
        {
            textscore5 = "2      " + NameText.userIDs + "      " + myObject.score;
            score1 = myObject.score;
        }
        else if (myObject.score < score1 && myObject.score > score2)
        {  
            textscore6 = "3      " + NameText.userIDs + "      " + myObject.score;
            score2 = myObject.score;
        }
        
        myObject.score1 = score;
        myObject.score2 = score1;
        myObject.score3 = score2;
        myObject.textscore1 = textscore4;
        myObject.textscore2 = textscore5;
        myObject.textscore3 = textscore6;
       
        


       




        var json = JsonUtility.ToJson(myObject);


        PlayerPrefs.SetString("Save", json);

        PlayerPrefs.Save();

    }

    public void Bingo2()
    {

        string json = PlayerPrefs.GetString("Save");

        myObject = JsonUtility.FromJson<SaveHighScoreJson.MyClass>(json);





       score = myObject.score1;
        score1 = myObject.score2;
       score2 = myObject.score3;
        
        
        textscore4 = myObject.textscore1;
        textscore5 = myObject.textscore2;
        textscore6 = myObject.textscore3;


        PlayerPrefs.Save();


        loaded = true;

    }
    public void Bingo3()
    {
        WordDisplay.score = 0;

        myObject.score1 = 3;
        myObject.score2 = 2;
        myObject.score3 = 1;
        myObject.textscore1 = "";
        myObject.textscore2 = "";
        myObject.textscore3 = "";









        var json = JsonUtility.ToJson(myObject);


        PlayerPrefs.SetString("Save", json);

        PlayerPrefs.Save();

    }
    public void Bingo4()
    {

        string json = PlayerPrefs.GetString("Save");

        myObject = JsonUtility.FromJson<SaveHighScoreJson.MyClass>(json);





     //   score = 3;
      //  score1 = 2;
       // score2 = 1;


        textscore4 = "";
        textscore5 = "";
        textscore6 = "";


        PlayerPrefs.Save();


        loaded = true;

    }

}
