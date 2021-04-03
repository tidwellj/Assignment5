using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bronze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SaveHighScoreJson.score2 == 8)
            gameObject.SetActive(false);
    }
}
