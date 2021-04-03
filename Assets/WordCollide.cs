using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WordCollide : MonoBehaviour
{
    public static int lives = 0;
    public static int destroyed = 0;
    public Scrollbar bar;
    public Scrollbar bar2;
    public Scrollbar bar3;
    public static int scores;
    public static int scoreA = 3;
    public static int scoreB = 2;
    public static int scoreC = 1;
    public static int scoreD = 0;
    public static int scoreE = 0;
    public static int scoreF = 0;


    private void Start()
    {
        bar2.size = .66f;
        bar.size = 1f;
        bar3.size = .33f;

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "word")
        {
            Destroy(col.gameObject);
            //public void Remove()
            bar.gameObject.SetActive(false);

            if (lives == 2)
                bar2.gameObject.SetActive(false);

            if (lives == 3)
            {

                bar.gameObject.SetActive(false);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                scores = WordDisplay.score;

                if (WordDisplay.score > scoreA)
                {
                    scoreA = WordDisplay.score;
                }
                else if (WordDisplay.score < scoreA && WordDisplay.score > scoreB)
                {
                    scoreB = WordDisplay.score;
                }
                else if (WordDisplay.score < scoreB && WordDisplay.score > scoreC)
                {
                    scoreC = WordDisplay.score;
                }



                scoreD = scoreA;
                scoreE = scoreB;
                scoreF = scoreC;





            }
            lives++;

        }
    }




}
