using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    //GameObject gold;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (SaveHighScoreJson.score == 10 || SaveHighScoreJson.score == 0)
            gameObject.SetActive(false);

        Debug.Log(SaveHighScoreJson.score);
       
    }
}
