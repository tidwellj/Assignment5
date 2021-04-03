using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class SaveHighScoreJson : MonoBehaviour
{
   
    static public int score = 10;
    static public int score1 = 9;
    static public int score2 = 8;
    static public int score3 = 7;
    static public int score4 = 6;
    static public int score5 = 5;
    static public int score6 = 4;
    static public int score7 = 3;
    static public int score8 = 2;
    static public int score9 = 1;

    public static string textscore4;
    public static string textscore5;
    public static string textscore6;
    public static string textscore7;
    public static string textscore8;
    public static string textscore9;
    public static string textscore10;
    public static string textscore11;
    public static string textscore12;
    public static string textscore13;

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
        public int score4;
        public int score5;
        public int score6;
        public int score7;
        public int score8;
        public int score9;
        public int score10;

        public string textscore1;
        public string textscore2;
        public string textscore3;
        public string textscore4;
        public string textscore5;
        public string textscore6;
        public string textscore7;
        public string textscore8;
        public string textscore9;
        public string textscore10;

    }
    public SaveHighScoreJson.MyClass myObject = new SaveHighScoreJson.MyClass();


    public void Bingo()
    {

        myObject.score = WordDisplay.score;


        if (myObject.score > score)
        {
            textscore4 ="1st      " + NameText.userIDs + "      " + myObject.score;
            score = myObject.score;
        }
        else if (myObject.score < score && myObject.score > score1)
        {
            textscore5 = "2nd      " + NameText.userIDs + "      " + myObject.score;
            score1 = myObject.score;
        }
        else if (myObject.score < score1 && myObject.score > score2)
        {  
            textscore6 = "3rd      " + NameText.userIDs + "      " + myObject.score;
            score2 = myObject.score;
        }

        else if (myObject.score < score2 && myObject.score > score3)
        {
            textscore7 = "4th      " + NameText.userIDs + "      " + myObject.score;
            score3 = myObject.score;
        }
        else if (myObject.score < score3 && myObject.score > score4)
        {
            textscore8 = "5th      " + NameText.userIDs + "      " + myObject.score;
            score4 = myObject.score;
        }
        else if (myObject.score < score4 && myObject.score > score5)
        {
            textscore9 = "6th      " + NameText.userIDs + "      " + myObject.score;
            score5 = myObject.score;
        }
        else if (myObject.score < score5 && myObject.score > score6)
        {
            textscore10 ="7th      " + NameText.userIDs + "      " + myObject.score;
            score6 = myObject.score;
        }
        else if (myObject.score < score6 && myObject.score > score7)
        {
            textscore11 = "8th     " + NameText.userIDs + "      " + myObject.score;
            score7 = myObject.score;
        }

        else if (myObject.score < score7 && myObject.score > score8)
        {
            textscore12 ="9th      " + NameText.userIDs + "      " + myObject.score;
            score8 = myObject.score;
        }

        else if (myObject.score < score8 && myObject.score > score9)
        {
            textscore12 ="10th     " + NameText.userIDs + "      " + myObject.score;
            score9 = myObject.score;
        }

        myObject.score1 = score;
        myObject.score2 = score1;
        myObject.score3 = score2;


        myObject.score4 = score3;
        myObject.score5 = score4;
        myObject.score6 = score5;

        myObject.score7 = score6;
        myObject.score8 = score7;
        myObject.score9 = score8;

        myObject.score10 = score9;

        myObject.textscore1 = textscore4;
        myObject.textscore2 = textscore5;
        myObject.textscore3 = textscore6;


        myObject.textscore4 = textscore7;
        myObject.textscore5 = textscore8;
        myObject.textscore6 = textscore9;


        myObject.textscore7 = textscore10;
        myObject.textscore8 = textscore11;
        myObject.textscore9 = textscore12;


        myObject.textscore10 = textscore13;
        




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


        score3 = myObject.score4;
        score4 = myObject.score5;
        score5 = myObject.score6;

        score6 = myObject.score7;
        score7 = myObject.score8;
        score8 = myObject.score9;
        score9 = myObject.score10;


        textscore4 = myObject.textscore1;
        textscore5 = myObject.textscore2;
        textscore6 = myObject.textscore3;

        textscore7 = myObject.textscore4;
        textscore8 = myObject.textscore5;
        textscore9 = myObject.textscore6;
        textscore10 = myObject.textscore7;
        textscore11 = myObject.textscore8;
        textscore12 = myObject.textscore9;
        textscore13 = myObject.textscore10;


        PlayerPrefs.Save();


        loaded = true;

    }
    public void Bingo3()
    {
        WordDisplay.score = 0;

        myObject.score1 = 10;
        myObject.score2 = 9;
        myObject.score3 = 8;
        myObject.score4 = 7;
        myObject.score5 = 6;
        myObject.score6 = 5;
        myObject.score7 = 4;
        myObject.score8 = 3;
        myObject.score9 = 2;
        myObject.score10 = 1;
        myObject.textscore1 = "";
        myObject.textscore2 = "";
        myObject.textscore3 = "";
        myObject.textscore4 = "";
        myObject.textscore5 = "";
        myObject.textscore6 = "";
        myObject.textscore7 = "";
        myObject.textscore8 = "";
        myObject.textscore9 = "";
        myObject.textscore10 = "";







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
        textscore4 = "";
        textscore5 = "";
        textscore6 = "";
        textscore7 = "";
        textscore8 = "";
        textscore9 = "";
        textscore10 = "";
        textscore11 = "";
        textscore12= "";
        textscore13 = "";

        PlayerPrefs.Save();


        loaded = true;

    }

}
