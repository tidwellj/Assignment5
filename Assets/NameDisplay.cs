using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = NameText.userIDs;
        Debug.Log(NameText.userIDs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
