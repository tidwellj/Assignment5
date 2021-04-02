using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class SaveHighScoreJson : MonoBehaviour
{

    // static public bool expo2;
    //static public int altScore = 0;
    static public int score = 350;
    static public int score1 = 250;
    static public int score2 = 150;
    public static string textscore4;
    public static string textscore5;
    public static string textscore6;
    public static int nam = 0;
    public static int nam2 = 0;
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

        // public int music;


    }
    public SaveHighScoreJson.MyClass myObject = new SaveHighScoreJson.MyClass();


    public void Bingo()
    {

        myObject.score = WordDisplay.score;
        Debug.Log(myObject.score + "wahhhh");


        if (myObject.score > score)
        {
            score = myObject.score;
            nam = 1;
        }
        else if (myObject.score < score && myObject.score > score1)
        {
            score1 = myObject.score;
            nam = 1;
        }
        else if (myObject.score < score1 && myObject.score > score2)
        {
            score2 = myObject.score;
            nam = 1;
        }
        myObject.score1 = score;
        myObject.score2 = score1;
        myObject.score3 = score2;




        if (nam == 1)
        {
            myObject.textscore1 = NameText.userIDs + " " + score.ToString();
            nam = 0;
            nam2 = 1;
        }


        if (nam == 1)
        {
            myObject.textscore2 = NameText.userIDs + " " + score1.ToString();
            nam = 0;
            nam2 = 1;
        }



        if (nam == 1)
        {
            myObject.textscore3 = NameText.userIDs + " " + score2.ToString();
            nam = 0;
            nam2 = 1;
        }


        //  myObject.textscore1 = myObject.textscore1;


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
        if (nam2 == 1)
        {
            textscore4 = myObject.textscore1 = NameText.userIDs + " " + score.ToString();
        }
        else
        {
            textscore4 = myObject.textscore1;
        }
        if (nam2 == 1)
        {
            textscore5 = myObject.textscore2 = NameText.userIDs + " " + score.ToString();
        }
        else
        {
            textscore5 = myObject.textscore2;
        }
        if (nam2 == 1)
        {
            textscore6 = myObject.textscore3 = NameText.userIDs + " " + score.ToString();
        }
        else
        {
            textscore6 = myObject.textscore3;
        }
        textscore4 = myObject.textscore1;
        textscore5 = myObject.textscore2;
        textscore6 = myObject.textscore3;


        PlayerPrefs.Save();




        // expo2 = true;
    }


}
