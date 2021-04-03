using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text text;
    public Text text2;
    public Text text3;

    public Text text4;
    public Text text5;
    public Text text6;

    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;

    public static string score;
    public static string score1;

    public static string score2;
    public static string score3;
    public static string score4;

    public static string score5;
    public static string score6;
    public static string score7;

    public static string score8;
    public static string score9;

    // Start is called before the first frame update





    // Update is called once per frame
    void Update()
    {
        // if (SaveHighScoreJson.expo2 == true)
        FindObjectOfType<SaveHighScoreJson>().Bingo2();

        FindObjectOfType<SaveHighScoreJson>().Bingo();

        score = SaveHighScoreJson.textscore4;
        text.text = score;

        score1 = SaveHighScoreJson.textscore5;
        text2.text = score1;

        score2 = SaveHighScoreJson.textscore6;
        text3.text = score2;

        score3 = SaveHighScoreJson.textscore7;
        text4.text = score3;

        score4 = SaveHighScoreJson.textscore8;
        text5.text = score4;

        score5 = SaveHighScoreJson.textscore9;
        text6.text = score5;
        score6 = SaveHighScoreJson.textscore10;
        text7.text = score6;

        score7 = SaveHighScoreJson.textscore11;
        text8.text = score7;

        score8 = SaveHighScoreJson.textscore12;
        text9.text = score8;

        score9 = SaveHighScoreJson.textscore13;
        text10.text = score9;

        //}
        /*
        else
        {//
            score = WordCollide.scoreA;
            text.text = score.ToString();
            Debug.Log(score);

            score1 = WordCollide.scoreB;
            text2.text = score1.ToString();
            Debug.Log(score1);

            score2 = WordCollide.scoreC;
            text3.text = score2.ToString();
            Debug.Log(score2);
        }
        */


        WordCollide.lives = 0;
    }
}
