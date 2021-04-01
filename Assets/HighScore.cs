using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text text;
    public Text text2;
    public Text text3;
    public static int score;
    public static int score1;

    public static int score2;
    // Start is called before the first frame update


    

    // Update is called once per frame
    void Update()
    {
        // if (SaveHighScoreJson.expo2 == true)
        // {
        score = SaveHighScoreJson.score ;
            text.text = score.ToString();
            Debug.Log("barggon" + score);

            score1 = SaveHighScoreJson.score1;
            text2.text = score1.ToString();
            Debug.Log(score1);

            score2 = SaveHighScoreJson.score2;
            text3.text = score2.ToString();
            Debug.Log("barg" + score2);
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
    }
}
