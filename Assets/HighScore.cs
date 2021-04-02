using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text text;
    public Text text2;
    public Text text3;
    public static string score;
    public static string score1;

    public static string score2;
    // Start is called before the first frame update




    // Update is called once per frame
    void Update()
    {
        // if (SaveHighScoreJson.expo2 == true)
        // {
        FindObjectOfType<SaveHighScoreJson>().Bingo();

        score = SaveHighScoreJson.textscore4;
        text.text = score;

        score1 = SaveHighScoreJson.textscore5;
        text2.text = score1;

        score2 = SaveHighScoreJson.textscore6;
        text3.text = score2;
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
