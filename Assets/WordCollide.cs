using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WordCollide : MonoBehaviour
{
    public static int lives = 0;

    public Scrollbar bar;
    public Scrollbar bar2;
    public Scrollbar bar3;
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

            bar.gameObject.SetActive(false);
           // bar2.size = bar.size - .25f;

            if (lives == 2)
                bar2.gameObject.SetActive(false);

            if (lives == 3)
            {

                    bar.gameObject.SetActive(false);
                    Debug.Log("colided");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                WordDisplay.score = 0;
            }
            lives++;

        }
    }

   


}
