using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SaveHighScoreJson.score1 ==9)
            gameObject.SetActive(false);
    }
}
